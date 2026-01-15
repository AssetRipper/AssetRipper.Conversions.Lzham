using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@lzdecision@lzcompressor@lzham@@QEAAXHHH@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::lzdecision::init(int, int, int)")]
[CleanName("init")]
internal static partial class init_jzbtc6
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist)
	{
		unchecked
		{
			((lzham_CLZDecompBase*)@this)->m_cur_ofs = pos;
			((lzham_CLZDecompBase*)@this)->m_cur_state = len;
			((lzham_CLZDecompBase*)@this)->m_match_hist = dist;
		}
	}
}
