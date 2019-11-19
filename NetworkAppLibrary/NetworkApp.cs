using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAppLibrary
{
    public enum MessageType { Text, Test, RegistrationForm, RegisteryFormSuccess, CheckLogIn, GetAnswer, Message }
    public struct TransferInfo
    {
        public int Size;
        public MessageType Type;
        public TransferInfo(int size, MessageType type)
        {
            Size = size;
            Type = type;
        }

        public byte[] ToBytes()
        {
            int size = Marshal.SizeOf(this);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(this, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        public static TransferInfo FromBytes(byte[] arr)
        {
            TransferInfo str = new TransferInfo();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (TransferInfo)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }
    }
}
