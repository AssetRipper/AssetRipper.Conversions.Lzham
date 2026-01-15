using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?compress_block@lzcompressor@lzham@@AEAA_NPEBXI@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::compress_block(void const *, unsigned int)")]
internal static partial class compress_block
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		int num = 0;
		int num2 = buf_len;
		unchecked
		{
			while (num2 != 0)
			{
				int num3 = minimum_c94n3m.Invoke(Get_max_add_bytes.Invoke(&((lzham_lzcompressor*)@this)->field_5), num2);
				bool flag = compress_block_internal.Invoke(@this, (byte*)pBuf + (uint)num, num3);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
				num += num3;
				num2 -= num3;
			}
			return true;
		}
	}
}
