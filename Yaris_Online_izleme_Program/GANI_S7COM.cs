using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHJSW.ComDrvS7V6_Net;
using System.Collections;
using System.Windows.Forms;


namespace Yaris_Online_izleme_Programı
{
    class GANI_S7COM
    {
        //////defines
        public const int ITEMINDEX_RS232_BAUDRATE_19200 = 0;
        public const int ITEMINDEX_RS232_BAUDRATE_38400 = 1;
        public const int ITEMINDEX_RS232_BAUDRATE_57600 = 2;
        public const int ITEMINDEX_RS232_BAUDRATE_115200 = 3;
        //
        public const int ITEMINDEX_HSA_15 = 0;
        public const int ITEMINDEX_HSA_31 = 1;
        public const int ITEMINDEX_HSA_63 = 2;
        public const int ITEMINDEX_HSA_126 = 3;
        //
        public const int CONNECTION_RS232_TABINDEX = 0;
        public const int CONNECTION_NETLINK_TABINDEX = 1;
        public const int CONNECTION_TCP_TABINDEX = 2;
        public const int CONNECTION_NETLINKPRO_TABINDEX = 3;
        public const int CONNECTION_SIMATIC_NET_TABINDEX = 4;
        //
        public const int MESSAGE_TYP_INFO = 100;
        public const int MESSAGE_TYP_ERROR = 101;
        public const int MESSAGE_TYP_MESSAGE = 102;
        //
        public const int ACTION_TYPE_MIXREAD = 0;
        public const int ACTION_TYPE__MIXWRITE = 1;
        public const int ACTION_TYPE__ORDERNO_CPU = 2;
        public const int ACTION_TYPE__MODE_CPU = 3;
        public const int ACTION_TYPE__READ_DATE = 4;
        public const int ACTION_TYPE_WRITE_DATE = 5;
        public const int ACTION_TYPE_DB_FROM_PLC_TO_WLD = 6;
        public const int ACTION_TYPE_DB_FROM_WLD_TO_PLC = 7;
        public const int ACTION_TYPE_GET_AMOUNT_DB_IN_WLD = 8;
        public const int ACTION_TYPE_SET_PLC_TO_STOP = 9;
        public const int ACTION_TYPE_SET_PLC_TO_RUN_WARM_RESTART = 10;
        public const int ACTION_TYPE_SET_PLC_TO_RUN_HOT_RESTART = 11;
        public const int ACTION_TYPE_COPY_RAM_TO_ROM = 12;
        public const int ACTION_TYPE_GET_SYSTEM_VALUES = 13;
        public const int ACTION_TYPE_READ_IDENT_DATA = 14;
        public const int ACTION_TYPE_PLC_BACKUP = 15;
        public const int ACTION_TYPE_PLC_DELETE = 16;
        public const int ACTION_TYPE_PLC_RESTORE = 17;

        // public static string TCP_IPAddr = "192.168.16.1";
        public static string TCP_IPAddr = "192.168.16.1";
        public static int TCP_SlotNo = 1;
        public static ushort MPI_ErrorCode = 0;
        public static string MPI_ErrorStr = String.Empty;
        public string PLC_Message_Label = "";
        public static bool MPI_OpenCommunicationExecuted = false;
        public static bool MPI_ConnectToPlcExecuted = false;
        public static int MPIAddressOfCommunication = 2;
        public bool SoketDurum = false;
        public bool BaglantiDurum = false;

        public static ComDrvS7V6 ComDrvS7Dll;
        
        #region MyRegion
        public void Conn(string PLCtype , string IP)
        {
            TCP_IPAddr = IP;
            ComDrvS7Dll = new ComDrvS7V6("", "", "", false, false);//Keine Registrierung, Meldung in deutsch, keine Exceptions
            if (!EvaluateTCPTab())
            {
                //
                return;
            }//end if
            if (PLCtype == "S71200")
            {
                if (!ComDrvS7Dll.MPI6_OpenTcpIp_S71200(TCP_IPAddr, out MPI_ErrorCode))
                {
                    ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                    ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                    //
                    // this.Cursor = Cursors.Default;
                    return;
                }//end if
                else
                {
                    ShowMessageText("Open communication sucessful.", MESSAGE_TYP_INFO);
                    MPI_OpenCommunicationExecuted = true;
                    SoketDurum = true;
                }//end else
            }
            else if (PLCtype == "S71500")
            {
                if (!ComDrvS7Dll.MPI6_OpenTcpIp_S71500(TCP_IPAddr, out MPI_ErrorCode))
                {
                    ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                    ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                    //
                    // this.Cursor = Cursors.Default;
                    return;
                }//end if
                else
                {
                    ShowMessageText("Open communication sucessful.", MESSAGE_TYP_INFO);
                    MPI_OpenCommunicationExecuted = true;
                    SoketDurum = true;
                }//end else
            }

            ////2. buton

            if (!MPI_OpenCommunicationExecuted)
            {
                ShowMessageText("The connection is not open!", MESSAGE_TYP_ERROR);
                SoketDurum = false;
                return;
            }//end if
             //
             //    this.Cursor = Cursors.WaitCursor;
             //
            ComDrvS7Dll.MPI6_ConnectToPLC((byte)MPIAddressOfCommunication, out MPI_ErrorCode);
            if (MPI_ErrorCode != 0)
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //
                //     this.Cursor = Cursors.Default;
                return;
            }//end if
            else
            {
                MPI_ConnectToPlcExecuted = true;
                ShowMessageText("Connection to PLC was sucessful", MESSAGE_TYP_INFO);
                BaglantiDurum = true;
            }//end else       
             //
             //  this.Cursor = Cursors.Default;

        }
        private bool EvaluateTCPTab()
        {
            //Slot PLC
            //  TCP_SlotNo = (int)1;
            //IP-Address
            string FormatIPAddrStr = String.Empty;
            if (!IsCorrectIPAddress(TCP_IPAddr, ref FormatIPAddrStr))
            {
                ShowMessageText("Error: IP-address is not valid!", MESSAGE_TYP_ERROR);
                return false;
            }//end if
             //   TCP_IPAdr_TextBox.Text = FormatIPAddrStr;
            TCP_IPAddr = FormatIPAddrStr;
            //
            return true;
            //
        }
        private void ShowMessageText(string[] TextLines, byte MeldungTyp)
        {
            /*    switch (MeldungTyp)
                {
                    case MESSAGE_TYP_INFO: Message_Label.ForeColor = Color.Blue; break;
                    case MESSAGE_TYP_ERROR: Message_Label.ForeColor = Color.Red; break;
                    case MESSAGE_TYP_MESSAGE: Message_Label.ForeColor = SystemColors.WindowText; break;
                    default: Message_Label.ForeColor = SystemColors.WindowText; break;
                }//end switch*/
            //Delete lines in Textbox
            PLC_Message_Label = "";
            //Insert new Text 
            for (int i = 0; i < TextLines.Length; i++)
            {
                PLC_Message_Label += TextLines[i] + Environment.NewLine;
            }//end for
             //
        }
        private void ShowMessageText(string Text, byte MessageType)
        {
            /*  switch (MessageType)
              {
                  case MESSAGE_TYP_INFO: Message_Label.ForeColor = Color.Blue; break;
                  case MESSAGE_TYP_ERROR: Message_Label.ForeColor = Color.Red; break;
                  case MESSAGE_TYP_MESSAGE: Message_Label.ForeColor = SystemColors.WindowText; break;
                  default: Message_Label.ForeColor = SystemColors.WindowText; break;
              }//end switch*/
            // 
            PLC_Message_Label = Text;
        }
        #endregion

        #region Bool Operation
        public bool[] readBool(string type, ushort DBno, ushort Adress, ushort Bit, ushort Cnt)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return null;
            }//end if
             //
            // this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            int cnttt = 1 + ((Bit + Cnt - 1) / 8);
            ushort byteCnt = (ushort)cnttt;
            ushort AmountBytes = (ushort)(1 + Cnt / 8);
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadByte(operand, (ushort)Adress, out StatusBuffer, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return null;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) are read", AmountBytes), MESSAGE_TYP_INFO);
          //FillStatusListBox(StatusBuffer, AmountBytes);
           // this.Cursor = Cursors.Default;
            var bits = new BitArray(BitConverter.GetBytes(StatusBuffer[0]).ToArray());

            return null;
        }
        public void writeBool(string type, ushort DBno, ushort Adress, byte Bit, byte value)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
             //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
             //Read data from PLC
            if (!ComDrvS7Dll.MPI6_WriteBit_2(operand, Adress, Bit, value, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return;
            }//end if
        }
        #endregion
        #region Byte Operation
        public byte[] readByte(string type, ushort DBno, ushort Adress, ushort Cnt)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return null;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            ushort AmountBytes = (ushort)Cnt;
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadByte(operand, (ushort)Adress, out StatusBuffer, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return null;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) are read", AmountBytes), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;
            return StatusBuffer;
        }
        public void writeByte(string type, ushort DBno, ushort Adress, ushort Cnt, byte[] values)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            ushort AmountBytes = (ushort)Cnt;
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_WriteByte(operand, (ushort)Adress, values, Cnt, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return;
            }//end if
             //Show data
            ShowMessageText(String.Format("{0} Byte(s) were written. Value {1} dez (0x{1:X02})", Cnt, values), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;

        }
        #endregion
        #region Int Operation
        public int[] readInt(string type, ushort DBno, ushort Adress, ushort Cnt)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return null;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            ushort AmountWords = (ushort)Cnt;
            ushort[] StatusBuffer = new ushort[AmountWords];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadWord(operand, (ushort)Adress, out StatusBuffer, AmountWords, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return null;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) are read", AmountWords), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;

            //   MessageBox.Show(Convert.ToInt16(65536 - StatusBuffer[0]).ToString());

            int[] statusValue = new int[StatusBuffer.Length];
            for (int i = 0; i < StatusBuffer.Length; i++)
            {
                if (StatusBuffer[i] > 32767)
                {
                    statusValue[i] = StatusBuffer[i] - 65536;
                }
                else
                {
                    statusValue[i] = StatusBuffer[i];
                }
            }
            return statusValue;
        }
        public void writeInt(string type, ushort DBno, ushort Adress, ushort Cnt, int[] values)
        {
            //
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if
             //
             //   this.Cursor = Cursors.WaitCursor;
             //Amount
            ushort AmountWord = (ushort)Cnt;
            ushort[] WriteBuffer = new ushort[AmountWord];
            ushort WriteValue = 0;
            //
            /* try
             {
                 WriteValue = Convert.ToUInt16(values[);
             }
             catch (Exception)
             {
                 ShowMessageText("The word-value is not valid!", MESSAGE_TYP_ERROR);
                 this.Cursor = Cursors.Default;
                 return;
             }*/
            //            
            for (int i = 0; i < AmountWord; i++)
            {
                if (values[i] < 0)
                {
                    WriteBuffer[i] = Convert.ToUInt16(65536 + values[i]);
                }
                else
                {
                    WriteBuffer[i] = Convert.ToUInt16(values[i]);
                }

            }//end for
            //What kind of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Write data into the PLC
            if (!ComDrvS7Dll.MPI6_WriteWord(operand, (ushort)Adress, WriteBuffer, AmountWord, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) were written. Value {1} dez (0x{1:X04})", AmountWord, WriteValue), MESSAGE_TYP_INFO);
            //
            // this.Cursor = Cursors.Default;
            //                
        }
        #endregion
        #region DInt Operation
        public int[] readDInt(string type, ushort DBno, ushort Adress, ushort Cnt)
        {
            //
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return null;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //
             //evaluate the amount of reading DWords 
            ushort AmountDwords = (ushort)Cnt;
            uint[] StatusBuffer = new uint[AmountDwords];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadDword(operand, (ushort)Adress, out StatusBuffer, AmountDwords, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //  this.Cursor = Cursors.Default;
                return null;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} DWord(s) are read", AmountDwords), MESSAGE_TYP_INFO);
            // FillStatusListBox(StatusBuffer, AmountDwords);
            // this.Cursor = Cursors.Default;
            int[] statusValue = new int[StatusBuffer.Length];
            for (int i = 0; i < StatusBuffer.Length; i++)
            {
                if (StatusBuffer[i] > 2147483647)
                {
                    statusValue[i] = (Int32)(StatusBuffer[i] - 4294967296);
                }
                else
                {
                    statusValue[i] = (Int32)StatusBuffer[i];
                }
            }
            return statusValue;
        }
        public void writeDInt(string type, ushort DBno, ushort Adress, ushort Cnt, int[] values)
        {
            //
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if
            //
            //this.Cursor = Cursors.WaitCursor;
            //Amount
            ushort AmountDword = (ushort)Cnt;
            uint[] WriteBuffer = new uint[AmountDword];
            uint WriteValue = 0;
            //
            /* try
             {
                 WriteValue = Convert.ToUInt32(WriteValueTextBox.Text);
             }
             catch (Exception)
             {
                 ShowMessageText("The word-value is not valid!", MESSAGE_TYP_ERROR);
                 this.Cursor = Cursors.Default;
                 return;
             }*/
            //            
            for (int i = 0; i < AmountDword; i++)
            {
                if (values[i] < 0)
                {
                    WriteBuffer[i] = Convert.ToUInt32(4294967296 + values[i]);
                }
                else
                {
                    WriteBuffer[i] = Convert.ToUInt32(values[i]);
                }
            }//end for
            //What kind of operand?
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Write data into PLC
            if (!ComDrvS7Dll.MPI6_WriteDword(operand, (ushort)Adress, WriteBuffer, AmountDword, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //this.Cursor = Cursors.Default;
                return;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) were written. Value {1} dez (0x{1:X04})", AmountDword, WriteValue), MESSAGE_TYP_INFO);
            //
            // this.Cursor = Cursors.Default;
        }
        #endregion
        #region Real Operation
        public Single[] readReal(string type, ushort DBno, ushort Adress, ushort Cnt)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return null;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            ushort AmountBytes = (ushort)(Cnt * 4);
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadByte(operand, (ushort)Adress, out StatusBuffer, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return null;
            }//end if
            //Show data
            ShowMessageText(String.Format("{0} Byte(s) are read", AmountBytes), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;

            Single[] Result = new Single[Cnt];
            byte[] temp = new byte[Cnt * 4];

            for (int i = 0; i < Cnt * 4; i = i + 4)
            {
                temp[i + 3] = StatusBuffer[i];
                temp[i + 2] = StatusBuffer[i + 1];
                temp[i + 1] = StatusBuffer[i + 2];
                temp[i] = StatusBuffer[i + 3];
                Result[i / 4] = BitConverter.ToSingle(temp, i);
            }
            return Result;
        }
        public void writeReal(string type, ushort DBno, ushort Adress, ushort Cnt, Single[] values)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if

            byte[] valueSingle = new byte[Cnt * 4];
            byte[] temp = new byte[4];
            for (int i = 0; i < Cnt * 4; i = i + 4)
            {
                temp = BitConverter.GetBytes(values[i / 4]);
                valueSingle[i] = temp[3];
                valueSingle[i + 1] = temp[2];
                valueSingle[i + 2] = temp[1];
                valueSingle[i + 3] = temp[0];
            }
            //
            //  this.Cursor = Cursors.WaitCursor;
            //evaluate the amount of reading Bytes 
            ushort AmountBytes = (ushort)(Cnt * 4);
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_WriteByte(operand, (ushort)Adress, valueSingle, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return;
            }//end if
             //Show data
            ShowMessageText(String.Format("{0} Byte(s) were written. Value {1} dez (0x{1:X02})", Cnt, values), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;
        }

        #endregion
        #region String Operation
        public string ReadString(string type, ushort DBno, ushort Adress, ushort _CharCnt, bool _string)
        {
            //    MessageBox.Show(PLC.ReadString("DB", 1, 4, 5));
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return "";
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            ushort AmountBytes = (ushort)_CharCnt;
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return null;
            }

            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = DBno;
                if (_string)
                    Adress = (ushort)(Adress + 2);
            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_ReadByte(operand, (ushort)(Adress), out StatusBuffer, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return "";
            }//end if
             //Show data
             //      ShowMessageText(String.Format("{0} Byte(s) are read", AmountBytes), MESSAGE_TYP_INFO);
             //   FillStatusListBox(StatusBuffer, AmountBytes);
             // this.Cursor = Cursors.Default;
            string data = "";
            for (int i = 0; i < StatusBuffer.Length; i++)
            {
                data += Convert.ToChar(StatusBuffer[i]);
            }//end for
            return data;
            //  MessageBox.Show(data);
            /*ushort AmountBytes = 5;
            byte[] StatusBuffer = new byte[AmountBytes];
            byte operand = (byte)'D';
            ComDrvS7Dll.MPI6_ReadByte(operand,2, out StatusBuffer, AmountBytes, AmountBytes, out MPI_ErrorCode);
              for (int i = 0; i < StatusBuffer.Length; i++)
               {
                   MessageBox.Show(System.Text.Encoding.ASCII.GetString(StatusBuffer).ToString());
               }
            string data = "";
            for (int i = 0; i < StatusBuffer.Length; i++)
            {
                data += Convert.ToChar(StatusBuffer[i]);
            }//end for
            MessageBox.Show(data);*/
        }

        public void WriteString(string type, ushort DBno, ushort Adress, string Text, bool _string)
        {
            if (!MPI_ConnectToPlcExecuted)
            {
                ShowMessageText("Please execute the connection to the PLC.", MESSAGE_TYP_INFO);
                return;
            }//end if
             //
             //  this.Cursor = Cursors.WaitCursor;
             //evaluate the amount of reading Bytes 
            string editText = Text;
            if (_string)
                editText = "xx" + Text;
            byte[] byteValues = Encoding.ASCII.GetBytes(editText);
            if (_string)
            {
                byteValues[0] = (byte)254;
                byteValues[1] = (byte)Text.Length;
            }
            ushort AmountBytes = (ushort)byteValues.Length;
            byte[] StatusBuffer = new byte[AmountBytes];
            //Type of operand
            byte operand = 0;
            if (type.Equals("Input")) operand = (byte)'I';
            else if (type.Equals("Output")) operand = (byte)'Q';
            else if (type.Equals("Flag")) operand = (byte)'M';
            else if (type.Equals("DB")) operand = (byte)'D';
            else if (type.Equals("VM-area (LOGO)")) operand = (byte)'V';
            else
            {
                ShowMessageText("Unknown operand!", MESSAGE_TYP_ERROR);
                return;
            }
            //DB number
            ushort wDBNo = 0;
            if (operand == (byte)'D')
            {
                //
                wDBNo = (ushort)DBno;

            }//end if
            //Read data from PLC
            if (!ComDrvS7Dll.MPI6_WriteByte(operand, (ushort)Adress, byteValues, AmountBytes, wDBNo, out MPI_ErrorCode))
            {
                ComDrvS7Dll.MPI6_GetDLLErrorEng(out MPI_ErrorStr, MPI_ErrorCode);
                ShowMessageText(MPI_ErrorStr, MESSAGE_TYP_ERROR);
                //    this.Cursor = Cursors.Default;
                return;
            }//end if
             //Show data
            ShowMessageText(String.Format("{0} Byte(s) were written. Value {1} dez (0x{1:X02})", AmountBytes, byteValues), MESSAGE_TYP_INFO);
            //   FillStatusListBox(StatusBuffer, AmountBytes);
            //   this.Cursor = Cursors.Default;
        }

        #endregion
        public bool IsCorrectIPAddress(string EditStr, ref string FormatStr)
        {
            String[] IPEinzel;
            //String leeren
            FormatStr = String.Empty;
            //Eingabe in einzelne int-Werte aufteilen
            IPEinzel = EditStr.Split('.');
            //Es müssen 4 einzelne Strings sein
            if (IPEinzel.Length != 4)
            {
                return false;
            }//end if
            //Die einzelnen Adresse testen
            try
            {
                int IPAdr1 = Convert.ToInt32(IPEinzel[0]);
                int IPAdr2 = Convert.ToInt32(IPEinzel[1]);
                int IPAdr3 = Convert.ToInt32(IPEinzel[2]);
                int IPAdr4 = Convert.ToInt32(IPEinzel[3]);
                //Ist eine Adresse nicht im Bereich 0-255
                if (IPAdr1 < 0 || IPAdr1 > 255 ||
                    IPAdr2 < 0 || IPAdr2 > 255 ||
                    IPAdr3 < 0 || IPAdr3 > 255 ||
                    IPAdr4 < 0 || IPAdr4 > 255)
                {
                    //
                    return false;
                }//end if
                //IP-Adresse formatieren
                IPEinzel[0] = IPAdr1.ToString();
                IPEinzel[1] = IPAdr2.ToString();
                IPEinzel[2] = IPAdr3.ToString();
                IPEinzel[3] = IPAdr4.ToString();
                //
                FormatStr = String.Join(".", IPEinzel);
                //
                return true;
            }//end try
            catch
            {
                //
                return false;
            }//end catch
            //
        }

    }
}
