using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?crc32@lzham@@YAIIPEBE_K@Z")]
[DemangledName("unsigned int __cdecl lzham::crc32(unsigned int, unsigned char const *, unsigned __int64)")]
internal static partial class crc32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int crc, [NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len)
	{
		long num = buf_len;
		void* ptr2 = ptr;
		int num2 = crc;
		if (ptr2 == null)
		{
			return 0;
		}
		num2 ^= -1;
		unchecked
		{
			while (true)
			{
				long num3 = num;
				num = num3 + -1L;
				if (num3 == 0L)
				{
					break;
				}
				void* ptr3 = ptr2;
				ptr2 = (byte*)ptr3 + 1;
				sbyte b = *(sbyte*)ptr3;
				num2 = (num2 >>> 4) ^ ((int*)s_crc32.__pointer)[(uint)((num2 & 0xF) ^ ((byte)b & 0xF))];
				num2 = (num2 >>> 4) ^ ((int*)s_crc32.__pointer)[(uint)((num2 & 0xF) ^ ((byte)b >> 4))];
			}
			return num2 ^ -1;
		}
	}
}
