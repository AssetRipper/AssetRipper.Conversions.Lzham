using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?adler32@lzham@@YAIPEBX_KI@Z")]
[DemangledName("unsigned int __cdecl lzham::adler32(void const *, unsigned __int64, unsigned int)")]
internal static partial class adler32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pBuf, [NativeType("unsigned __int64")] long buflen, [NativeType("unsigned int")] int adler32)
	{
		long num = buflen;
		if (pBuf == null)
		{
			return 1;
		}
		void* ptr = pBuf;
		int num2 = adler32 & 0xFFFF;
		int num3 = adler32 >>> 16;
		unchecked
		{
			long num4 = (long)((ulong)num % 5552uL);
			while (num != 0L)
			{
				int i;
				for (i = 0; (ulong)(uint)(i + 7) < (ulong)num4; i += 8)
				{
					num2 += (byte)(*(sbyte*)ptr);
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[1];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[2];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[3];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[4];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[5];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[6];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr)[7];
					num3 += num2;
					ptr = (byte*)ptr + 8;
				}
				for (; (ulong)(uint)i < (ulong)num4; i++)
				{
					void* ptr2 = ptr;
					ptr = (byte*)ptr2 + 1;
					num2 += (byte)(*(sbyte*)ptr2);
					num3 += num2;
				}
				num2 = (int)((uint)num2 % 65521u);
				num3 = (int)((uint)num3 % 65521u);
				num -= num4;
				num4 = 5552L;
			}
			return (num3 << 16) + num2;
		}
	}
}
