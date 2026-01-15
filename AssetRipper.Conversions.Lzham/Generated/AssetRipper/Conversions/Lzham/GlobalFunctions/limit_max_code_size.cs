using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?limit_max_code_size@prefix_coding@lzham@@YA_NIPEAEI@Z")]
[DemangledName("bool __cdecl lzham::prefix_coding::limit_max_code_size(unsigned int, unsigned char *, unsigned int)")]
internal static partial class limit_max_code_size
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char *")] void* pCodesizes, [NativeType("unsigned int")] int max_code_size)
	{
		InlineArray35_Int32 inlineArray35_Int = default(InlineArray35_Int32);
		InlineArray35_Int32 inlineArray35_Int2 = default(InlineArray35_Int32);
		InlineArray1024_SByte inlineArray1024_SByte = default(InlineArray1024_SByte);
		unchecked
		{
			if (num_syms == 0 || (uint)num_syms > 1024u || (uint)max_code_size < 1u || (uint)max_code_size > 34u)
			{
				return false;
			}
			zero_object_jc2sde.Invoke(&inlineArray35_Int);
			sbyte b = 0;
			for (int i = 0; (uint)i < (uint)num_syms; i++)
			{
				int num = (byte)((sbyte*)pCodesizes)[(uint)i];
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)num * (nint)4)))++;
				if ((uint)num > (uint)max_code_size)
				{
					b = 1;
				}
			}
			if ((b & 1) != 1)
			{
				return true;
			}
			int num2 = 0;
			for (int j = 1; (uint)j <= 34u; j++)
			{
				Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int2, (nint)(uint)j * (nint)4)) = num2;
				num2 += Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)j * (nint)4));
			}
			if ((uint)num2 < 2u || (uint)num2 > 1024u)
			{
				return true;
			}
			if ((uint)num2 > (uint)(1 << max_code_size))
			{
				return false;
			}
			for (int k = max_code_size + 1; (uint)k <= 34u; k++)
			{
				*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)max_code_size * (nint)4)) += Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)k * (nint)4));
			}
			int num3 = 0;
			for (int l = max_code_size; l != 0; l += -1)
			{
				num3 += Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)l * (nint)4)) << max_code_size - l;
			}
			if (num3 == 1 << max_code_size)
			{
				return true;
			}
			do
			{
				*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)max_code_size * (nint)4)) += -1;
				int m;
				for (m = max_code_size - 1; m != 0; m += -1)
				{
					if (Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)m * (nint)4)) != 0)
					{
						*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)m * (nint)4)) += -1;
						*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)(m + 1) * (nint)4)) += 2;
						break;
					}
				}
				if (m == 0)
				{
					return false;
				}
				num3 += -1;
			}
			while (num3 != 1 << max_code_size);
			void* ptr = &inlineArray1024_SByte;
			for (int n = 1; (uint)n <= (uint)max_code_size; n++)
			{
				int num4 = Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int, (nint)(uint)n * (nint)4));
				if (num4 != 0)
				{
					llvm_memset_p0_i64.Invoke(ptr, (sbyte)n, (uint)num4, isVolatile: false);
					ptr = (byte*)ptr + (uint)num4;
				}
			}
			for (int num5 = 0; (uint)num5 < (uint)num_syms; num5++)
			{
				int num6 = (byte)((sbyte*)pCodesizes)[(uint)num5];
				if (num6 != 0)
				{
					((sbyte*)pCodesizes)[(uint)num5] = Unsafe.As<InlineArray1024_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray1024_SByte, (uint)Unsafe.As<InlineArray35_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray35_Int2, (nint)(uint)num6 * (nint)4))++));
				}
			}
			return true;
		}
	}
}
