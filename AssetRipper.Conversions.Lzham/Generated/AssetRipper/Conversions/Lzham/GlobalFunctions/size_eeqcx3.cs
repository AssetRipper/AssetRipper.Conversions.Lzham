using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<class lzham::adaptive_bit_model>::size(void) const")]
[CleanName("size")]
internal static partial class size_eeqcx3
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
