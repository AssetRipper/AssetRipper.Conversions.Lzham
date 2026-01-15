using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size_in_bytes@?$vector@I@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned int>::size_in_bytes(void) const")]
[CleanName("size_in_bytes")]
internal static partial class size_in_bytes_uw9qkk
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((int)((long)(uint)((lzham_vector*)@this)->m_size * 4L));
	}
}
