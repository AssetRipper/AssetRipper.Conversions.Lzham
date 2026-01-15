using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?generate_codes@prefix_coding@lzham@@YA_NIPEBEPEAG@Z")]
[DemangledName("bool __cdecl lzham::prefix_coding::generate_codes(unsigned int, unsigned char const *, unsigned short *)")]
internal static partial class generate_codes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char const *")] void* pCodesizes, [NativeType("unsigned short *")] void* pCodes)
	{
		InlineArray17_Int32 inlineArray17_Int = default(InlineArray17_Int32);
		InlineArray17_Int32 inlineArray17_Int2 = default(InlineArray17_Int32);
		zero_object_nua2vr.Invoke(&inlineArray17_Int);
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_syms; i++)
			{
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray17_Int, (nint)(byte)((sbyte*)pCodesizes)[(uint)i] * (nint)4)))++;
			}
			int num = 0;
			*(int*)(&inlineArray17_Int2) = 0;
			for (int j = 1; (uint)j <= 16u; j++)
			{
				Unsafe.As<InlineArray17_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray17_Int2, (nint)(uint)j * (nint)4)) = num;
				num = num + Unsafe.As<InlineArray17_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray17_Int, (nint)(uint)j * (nint)4)) << 1;
			}
			if (num != 131072)
			{
				int num2 = 0;
				for (int k = 1; (uint)k <= 16u; k++)
				{
					num2 += Unsafe.As<InlineArray17_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray17_Int, (nint)(uint)k * (nint)4));
					if ((uint)num2 > 1u)
					{
						return false;
					}
				}
			}
			for (int l = 0; (uint)l < (uint)num_syms; l++)
			{
				((short*)pCodes)[(uint)l] = (short)(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray17_Int2, (nint)(byte)((sbyte*)pCodesizes)[(uint)l] * (nint)4)))++;
			}
			return true;
		}
	}
}
