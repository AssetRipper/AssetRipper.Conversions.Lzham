using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@E@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned char>::size(void) const")]
[CleanName("size")]
internal static partial class size_s5xcpk
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
