using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size_in_bytes@?$vector@G@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned short>::size_in_bytes(void) const")]
[CleanName("size_in_bytes")]
internal static partial class size_in_bytes_pes8ki
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((int)((long)(uint)((lzham_vector*)@this)->m_size * 2L));
	}
}
