using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@I@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned int>::size(void) const")]
[CleanName("size")]
internal static partial class size_9n9s89
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
