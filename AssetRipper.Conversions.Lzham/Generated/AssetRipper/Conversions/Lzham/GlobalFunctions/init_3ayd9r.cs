using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@lzpriced_decision@lzcompressor@lzham@@QEAAXHHH_K@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::lzpriced_decision::init(int, int, int, unsigned __int64)")]
[CleanName("init")]
internal static partial class init_3ayd9r
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist, [NativeType("unsigned __int64")] long cost)
	{
		init_jzbtc6.Invoke(@this, pos, len, dist);
		unchecked((lzham_lzcompressor_lzpriced_decision*)@this)->field_1 = cost;
	}
}
