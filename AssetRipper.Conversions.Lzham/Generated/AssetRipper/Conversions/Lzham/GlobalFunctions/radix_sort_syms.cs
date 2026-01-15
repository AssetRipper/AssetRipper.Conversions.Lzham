using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?radix_sort_syms@lzham@@YAPEAUsym_freq@1@IPEAU21@0@Z")]
[DemangledName("struct lzham::sym_freq * __cdecl lzham::radix_sort_syms(unsigned int, struct lzham::sym_freq *, struct lzham::sym_freq *)")]
internal static partial class radix_sort_syms
{
	[return: NativeType("struct lzham::sym_freq *")]
	public unsafe static void* Invoke([NativeType("unsigned int")] int num_syms, [NativeType("struct lzham::sym_freq *")] void* syms0, [NativeType("struct lzham::sym_freq *")] void* syms1)
	{
		InlineArray512_Int32 inlineArray512_Int = default(InlineArray512_Int32);
		InlineArray256_Int32 inlineArray256_Int = default(InlineArray256_Int32);
		llvm_memset_p0_i64.Invoke(&inlineArray512_Int, 0, 2048L, isVolatile: false);
		void* ptr = syms0;
		unchecked
		{
			for (void* ptr2 = (byte*)syms0 + (nint)(uint)((num_syms >>> 1) * 2) * (nint)sizeof(lzham_sym_freq); ptr != ptr2; ptr = (byte*)ptr + (nint)2 * sizeof(lzham_sym_freq))
			{
				int freq = ((lzham_sym_freq*)ptr)->m_freq;
				int freq2 = ((lzham_sym_freq*)ptr)[1].m_freq;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(freq & 0xFF) * (nint)4)))++;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(256 + ((freq >>> 8) & 0xFF)) * (nint)4)))++;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(freq2 & 0xFF) * (nint)4)))++;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(256 + ((freq2 >>> 8) & 0xFF)) * (nint)4)))++;
			}
			if ((num_syms & 1) != 0)
			{
				int freq3 = ((lzham_sym_freq*)ptr)->m_freq;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(freq3 & 0xFF) * (nint)4)))++;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(256 + ((freq3 >>> 8) & 0xFF)) * (nint)4)))++;
			}
			void* ptr3 = syms0;
			void* ptr4 = syms1;
			int num = InstructionHelper.Select(Unsafe.As<InlineArray512_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray512_Int, 1024)) == num_syms, 1, 2);
			for (int i = 0; (uint)i < (uint)num; i++)
			{
				void* ptr5 = Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(i << 8) * (nint)4));
				int num2 = 0;
				for (int j = 0; (uint)j < 256u; j += 2)
				{
					Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)j * (nint)4)) = num2;
					num2 = (Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)(j + 1) * (nint)4)) = num2 + ((int*)ptr5)[(uint)j]) + ((int*)ptr5)[(uint)(j + 1)];
				}
				int num3 = i << 3;
				void* ptr6 = ptr3;
				for (void* ptr7 = (byte*)ptr3 + (nint)(uint)((num_syms >>> 1) * 2) * (nint)sizeof(lzham_sym_freq); ptr6 != ptr7; ptr6 = (byte*)ptr6 + (nint)2 * sizeof(lzham_sym_freq))
				{
					int num4 = ((lzham_sym_freq*)ptr6)->m_freq;
					int num5 = ((lzham_sym_freq*)ptr6)[1].m_freq;
					if (i != 0)
					{
						num4 >>>= 8;
						num5 >>>= 8;
					}
					num4 &= 0xFF;
					num5 &= 0xFF;
					if (num4 == num5)
					{
						int num6 = Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)num4 * (nint)4));
						Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)num4 * (nint)4)) = num6 + 2;
						llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)num6 * (nint)sizeof(lzham_sym_freq), ptr6, 8L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)(num6 + 1) * (nint)sizeof(lzham_sym_freq), (byte*)ptr6 + sizeof(lzham_sym_freq), 8L, isVolatile: false);
					}
					else
					{
						int num7 = (*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)num4 * (nint)4)))++;
						int num8 = (*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)num5 * (nint)4)))++;
						llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)num7 * (nint)sizeof(lzham_sym_freq), ptr6, 8L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)num8 * (nint)sizeof(lzham_sym_freq), (byte*)ptr6 + sizeof(lzham_sym_freq), 8L, isVolatile: false);
					}
				}
				if ((num_syms & 1) != 0)
				{
					llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)((((lzham_sym_freq*)ptr6)->m_freq >>> num3) & 0xFF) * (nint)4))++ * (nint)sizeof(lzham_sym_freq), ptr6, 8L, isVolatile: false);
				}
				void* ptr8 = ptr3;
				ptr3 = ptr4;
				ptr4 = ptr8;
			}
			return ptr3;
		}
	}
}
