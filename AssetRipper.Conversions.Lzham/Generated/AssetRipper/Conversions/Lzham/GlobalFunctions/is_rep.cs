using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?is_rep@lzdecision@lzcompressor@lzham@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::lzdecision::is_rep(void) const")]
internal static partial class is_rep
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((lzham_CLZDecompBase*)@this)->m_match_hist < 0;
	}
}
