using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$swap@Unode_state@lzcompressor@lzham@@$0A@@std@@YAXAEAUnode_state@lzcompressor@lzham@@0@Z")]
[DemangledName("void __cdecl std::swap<struct lzham::lzcompressor::node_state, 0>(struct lzham::lzcompressor::node_state &, struct lzham::lzcompressor::node_state &)")]
[CleanName("swap")]
internal static partial class swap_bdix5g
{
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("_Left")][NativeType("struct lzham::lzcompressor::node_state &")] void* Left, [MangledName("_Right")][NativeType("struct lzham::lzcompressor::node_state &")] void* Right)
	{
		lzham_lzcompressor_node_state lzham_lzcompressor_node_state2 = default(lzham_lzcompressor_node_state);
		llvm_memcpy_p0_p0_i64.Invoke(&lzham_lzcompressor_node_state2, Left, 56L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(Left, Right, 56L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(Right, &lzham_lzcompressor_node_state2, 56L, isVolatile: false);
	}
}
