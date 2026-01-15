using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0lzdecision@lzcompressor@lzham@@QEAA@HHH@Z")]
[DemangledName("public: __cdecl lzham::lzcompressor::lzdecision::lzdecision(int, int, int)")]
[CleanName("lzdecision_Constructor")]
internal static partial class lzdecision_Constructor_v5ftey
{
	public unsafe static void* Invoke(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist)
	{
		unchecked
		{
			((lzham_CLZDecompBase*)@this)->m_cur_ofs = pos;
			((lzham_CLZDecompBase*)@this)->m_cur_state = len;
			((lzham_CLZDecompBase*)@this)->m_match_hist = dist;
			return @this;
		}
	}
}
