/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/23
 * Time: 11:10
 * 
 */
using System;
using System.Runtime.InteropServices; 

namespace CommTest.Common
{
	/// <summary>
	/// Description of VSPD.
	/// </summary>
	public class VSPD
	{
		//[DllImport("VSPDCTL.dll", EntryPoint = "CreatePair", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        //public static extern bool CreatePair(byte[] comName1, byte[] comName2);  

        /// <summary>
        /// CreatePair creates a pair of virtual serial ports with given names. 
        /// It accepts two null-terminated strings determining which ports should be created as input. 
        /// For example, "COM5" and "COM6". 
        /// </summary>
        /// <param name="comName1">A null-terminated string that defines the name of the first port in a pair</param>
        /// <param name="comName2">A null-terminated string that defines the name of the second port in a pair</param>
        /// <returns>CreatePair returns TRUE if virtual serial pair was created successfully and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool CreatePair(string comName1, string comName2);

        /// <summary>
        /// DeletePair deletes a pair of virtual serial ports with a given name. 
        /// As input it takes name of any virtual serial port in a pair.
        /// For example, if you want to remove pair named "COM5"-"COM6", 
        /// you can pass either "COM5" or "COM6" as argument to DeletePair function.
        /// </summary>
        /// <param name="comName">  A null-terminated string that defines one of the two port names in a pair you want to delete </param>
        /// <returns>DeletePair returns TRUE if virtual serial pair was successfully deleted and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool DeletePair(string comName);

        /// <summary>
        /// DeleteAll deletes all virtual serial ports currently present in a system. It accepts no arguments at input. 
        /// </summary>
        /// <returns>DeleteAll returns TRUE if all virtual serial pairs were successfully deleted and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool DeleteAll();

        [DllImport("vspdctl.dll")]
        public static extern bool SetStrictBaudrateName(string comName, bool isStrictBaudrate);

        [DllImport("vspdctl.dll")]
        public static extern bool SetStrictBaudrateHandle(IntPtr handle, bool isStrictBaudrate);

        /// <summary>
        /// SetStrictBaudrate enables/disables full baudrate emulation, 
        /// needs the name of one of the paired virtual ports and boolean parameter
        /// that defines if strict baudrate emulation should be enabled or not.
        /// </summary>
        /// <param name="comName">A null-terminated string that defines one of the two port names in a pair </param>
        /// <param name="isStrictBaudrate">A boolean variable which should be TRUE 
        /// if you want to enable strict baudrate emulation and FALSE if you want to disable it</param>
        /// <returns>SetStrictBaudrate returns TRUE if strict baudrate emulation was successfully enabled and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool SetStrictBaudrate(string comName, bool isStrictBaudrate);

        /// <summary>
        /// SetBreak enables/disables line break emulation in virtual serial ports. 
        /// </summary>
        /// <param name="comName">A null-terminated string that defines one of the two port names in a pair</param>
        /// <param name="isBreak"> A boolean variable should be TRUE if you want to emulate connection break and FALSE if you want to re-establish it </param>
        /// <returns>SetBreak returns TRUE if line break emulation was successfully enabled and FALSE otherwise.</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool SetBreak(string comName, bool isBreak);

        /// <summary>
        /// QueryBus: QueryBus sends request to get complete information from the virtual serial bus installed by VSPD. 
        /// </summary>
        /// <param name="inBufferPtr">A pointer to VSBUS_QUERY or VSBUS_QUERY_EX structures. 
        /// If you want to get information about all current virtual serial ports 
        /// then use VSBUS_QUERY structure 
        /// and if you want to get extended information 
        /// about single virtual serial pair then use VSBUS_QUERY_EX structure.</param>
        /// <param name="inBufferSize"></param>
        /// <param name="outBufferPtr"></param>
        /// <param name="outBufferSize">A pointer to either PORT_INFORMATION or PORT_INFORMATION_EX structures list. 
        /// If you have used VSBUS_QUERY than you should get PORT_INFORMATION list 
        /// and if you used VSBUS_QUERY_EX then you should get PORT_INFORMATION_EX.</param>
        /// <returns></returns>
        [DllImport("vspdctl.dll")]
        public static extern bool QueryBus(IntPtr inBufferPtr, long inBufferSize, IntPtr outBufferPtr, long outBufferSize);

        /// <summary>
        /// SetWiring sets custom signal lines wiring (pinout). 
        /// </summary>
        /// <param name="comName">A null-terminated string that defines one of the two port names in a pair </param>
        /// <param name="bufferPtr">A pointer to VSERIAL_WIRING structure </param>
        /// <param name="bufferSize">Size of Buffer parameter in bytes </param>
        /// <returns>SetWiring returns TRUE if signal lines wiring was created successfully and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool SetWiring(string comName, IntPtr bufferPtr, long bufferSize);

        /// <summary>
        /// SetAccessList restricts access to created virtual serial ports for various applications. 
        /// </summary>
        /// <param name="comName"> A null-terminated string that defines one of the two port names in a pair </param>
        /// <param name="bufferPtr">A pointer to PROGRAM_ACCESS array </param>
        /// <param name="bufferSize">Size of Buffer parameter in bytes </param>
        /// <returns>SetAccessList returns TRUE if port access list was created successfully and FALSE otherwise</returns>
        [DllImport("vspdctl.dll")]
        public static extern bool SetAccessList(string comName, IntPtr bufferPtr, long bufferSize);

        //[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Ansi,Pack=1)]
        public struct _VSBUS_QUERY
        {
            /// <summary>
            /// VSBUS_QUERY structure size
            /// </summary>
            ulong Size;

            /// <summary>
            /// Has QUERYTYPE_PORTS = 1 value. Can be extended in the future. 
            /// </summary>
            ulong QueryType;
        };

        private const int MAX_PORTNAME_LEN = 6;
        
        public struct _VSBUS_QUERY_EX
        {
            /// <summary>
            /// VSBUS_QUERY_EX structure size
            /// </summary>
            ulong Size;

            /// <summary>
            /// 1:query all virtual ports.
            /// 2:query particular virtual pair
            /// 3:query particular virtual pair; name of the application, which created the port, is returned.
            /// </summary>
            ulong QueryType;

            /// <summary>
            /// Unicode name of any port in the pair you want to delete. 
            /// For instance, if "COM6-COM7" virtual serial ports pair was created, 
            /// then to remove it, PortName's value should be COM6 or COM7. 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PORTNAME_LEN)]
            string PortName;
        }
        
        public struct _PORT_INFORMATION
        {
            /// <summary>
            /// Offset of the next PORT_INFORMATION structure
            /// </summary>
            ulong NextOffset;

            /// <summary>
            /// Offset of the name
            /// </summary>
            ulong NameOffset;

			/// <summary>
            /// Instance of the virtual serial pair
            /// </summary>
            ulong Instance;

            /// <summary>
            /// Instance of remote port which is linked to current port
            /// </summary>
            ulong ConnectedInstance;
        }
        
        public struct _VSERIAL_WIRING
        {
            char DTR;

            char RTS;

            char OUT1;

            char OUT2;
        }
        
        public struct _VSERIAL_STATE
        {
        	/// <summary>
        	/// is TRUE if connection established and FALSE otherwise
        	/// </summary>
			ulong Opened; 
			
			/// <summary>
			/// is TRUE if Baudrate emulation is enabled and FALSE otherwise
			/// </summary>
			ulong StrictBaudrate;
			
			/// <summary>
			/// emulates physical line break (TRUE), in fact this option drops all incoming signal lines (DCD, DSR, CTS, RI) 
			/// and data from one port is not transferred to another.
			/// </summary>
			ulong Break;
		  	
			/// <summary>
		  	/// Not used at the moment (reserved for future use)
		  	/// </summary>
			ulong Reserved;
		}
        
        public struct _SERIAL_BAUD_RATE
        {
			/// <summary>
			/// Baudrate at which the communication device operates.
			/// </summary>
        	ulong BaudRate;
		} 
		
        public struct _SERIAL_HANDFLOW
        {
			/// <summary>
			/// ControlHandShake is a set of flags that defines the modem lines that are used for flow control. 
			/// Can be a combination of the following flags
			/// </summary>
        	ulong ControlHandShake;
			
        	/// <summary>
        	/// FlowReplace is a set of flags defining flow control stuff. Can be a combination of the following flags:
        	/// </summary>
        	ulong FlowReplace;
			
        	/// <summary>
        	/// Minimum number of bytes allowed in the input buffer before flow control is activated to inhibit the sender.	
        	/// </summary>
        	long XonLimit;
			
        	/// <summary>
        	/// Maximum number of bytes allowed in the input buffer before flow control is activated to allow transmission by the sender. 
        	/// </summary>
        	long XoffLimit;
		} 
		
        public struct _SERIAL_LINE_CONTROL
        {
			/// <summary>
			/// Number of stop bits to be used. This member can have one of the following values
			/// </summary>
        	char StopBits;
			
        	/// <summary>
        	/// Parity scheme to be used. This member can have one of the following values.
        	/// </summary>
        	char Parity;
			
        	/// <summary>
        	/// Number of bits in the bytes transmitted and received.
        	/// </summary>
        	char WordLength;
		} 


	}
}
