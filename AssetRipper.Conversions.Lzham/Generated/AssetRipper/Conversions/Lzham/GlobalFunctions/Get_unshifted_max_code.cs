using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_unshifted_max_code@decoder_tables@prefix_coding@lzham@@QEBAII@Z")]
[DemangledName("public: unsigned int __cdecl lzham::prefix_coding::decoder_tables::get_unshifted_max_code(unsigned int) const")]
internal static partial class Get_unshifted_max_code
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int len)
	{
		unchecked
		{
			int num = ((int*)(&((lzham_prefix_coding_decoder_tables*)@this)->m_max_codes))[(uint)(len - 1)];
			if (num == 0)
			{
				return -1;
			}
			return num - 1 >>> 16 - len;
		}
	}
}
