using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?object_mover@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@CAXPEAX0I@Z")]
[DemangledName("private: static void __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::object_mover(void *, void *, unsigned int)")]
[CleanName("object_mover")]
internal static partial class object_mover_fu5v7f
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, int, void>)(&Invoke));

	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void *")] void* pDst_void, [NativeType("void *")] void* pSrc_void, [NativeType("unsigned int")] int num)
	{
		void* ptr = pSrc_void;
		unchecked
		{
			void* ptr2 = (byte*)ptr + (nint)(uint)num * (nint)sizeof(lzham_CLZDecompBase);
			void* ptr3 = pDst_void;
			while (ptr != ptr2)
			{
				llvm_memcpy_p0_p0_i64.Invoke(ptr3, ptr, 12L, isVolatile: false);
				ptr = (byte*)ptr + sizeof(lzham_CLZDecompBase);
				ptr3 = (byte*)ptr3 + sizeof(lzham_CLZDecompBase);
			}
		}
	}
}
