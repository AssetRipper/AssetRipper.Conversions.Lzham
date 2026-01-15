using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?is_last@dict_match@lzham@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl lzham::dict_match::is_last(void) const")]
internal static partial class is_last
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((lzham_dict_match*)@this)->m_dist < 0;
	}
}
