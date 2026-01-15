using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_dist@dict_match@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::dict_match::get_dist(void) const")]
internal static partial class Get_dist
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_dict_match*)@this)->m_dist & 0x7FFFFFFF;
	}
}
