using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_all_tables@lzham_decompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_all_tables(void)")]
internal static partial class reset_all_tables
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		reset_huff_tables.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			reset_arith_tables.Invoke(@this);
		}
	}
}
