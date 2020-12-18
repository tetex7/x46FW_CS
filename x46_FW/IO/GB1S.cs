using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace x46_FW
{
	namespace IO
	{
		/// <summary>
		/// general byte stream
		/// </summary>
		public class GB1S
		{
            //public Stream BS { get; private set; }
            private MemoryStream BS = new MemoryStream();

            public bool CanRead { get; private set; }

            //public bool CanSeek => throw new NotImplementedException();

            public bool CanWrite { get; private set; }

            public long Length { get; private set; }

            public long Position { get; private set; }

            public GB1S()
            {
                
            }

            /// <summary>
            /// lock the bitstream
            /// </summary>
            public void Lock()
            {
                CanWrite = false;
            }

            /// <summary>
            /// unlock the bitstream
            /// </summary>
            public void UNlock()
            {
                CanWrite = true;
            }

            /// <summary>
            /// clears the bitstream
            /// </summary>
            public void Flush()
            {
                throw new NotImplementedException();
            }

            public int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns>a Byte Array</returns>
            public byte[] toByteArray()
			{
				using (MemoryStream ms = new MemoryStream())
				{
					BS.CopyTo(ms);
					return ms.ToArray();
				}
			}

            private long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            private void SetLength(long val)
            {
                Length = val;
            }

            public void reWrite(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public void Write(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }
        }
	}
}
