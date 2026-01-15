using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?object_mover@?$vector@Vadaptive_bit_model@lzham@@@lzham@@CAXPEAX0I@Z")]
[DemangledName("private: static void __cdecl lzham::vector<class lzham::adaptive_bit_model>::object_mover(void *, void *, unsigned int)")]
[CleanName("object_mover")]
internal static partial class object_mover_2wbuit
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, int, void>)(&Invoke));

	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void *")] void* pDst_void, [NativeType("void *")] void* pSrc_void, [NativeType("unsigned int")] int num)
	{
		void* ptr = pSrc_void;
		unchecked
		{
			void* ptr2 = (byte*)ptr + (nint)(uint)num * (nint)sizeof(lzham_adaptive_bit_model);
			void* ptr3 = pDst_void;
			while (ptr != ptr2)
			{
				adaptive_bit_model_Constructor_m7bfzj.Invoke(ptr3, ptr);
				ptr = (byte*)ptr + sizeof(lzham_adaptive_bit_model);
				ptr3 = (byte*)ptr3 + sizeof(lzham_adaptive_bit_model);
			}
		}
	}
}
