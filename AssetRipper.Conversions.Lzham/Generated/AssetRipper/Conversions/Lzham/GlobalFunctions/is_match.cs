using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?is_match@lzdecision@lzcompressor@lzham@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::lzdecision::is_match(void) const")]
internal static partial class is_match
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((lzham_CLZDecompBase*)@this)->m_cur_state > 0;
	}
}
