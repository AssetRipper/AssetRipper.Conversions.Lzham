using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?generate_huffman_codes@lzham@@YA_NPEAXIPEBGPEAEAEAI3@Z")]
[DemangledName("bool __cdecl lzham::generate_huffman_codes(void *, unsigned int, unsigned short const *, unsigned char *, unsigned int &, unsigned int &)")]
internal static partial class generate_huffman_codes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void *")] void* pContext, [NativeType("unsigned int")] int num_syms, [NativeType("unsigned short const *")] void* pFreq, [NativeType("unsigned char *")] void* pCodesizes, [NativeType("unsigned int &")] void* max_code_size, [NativeType("unsigned int &")] void* total_freq_ret)
	{
		InlineArray1024_Int32 inlineArray1024_Int = default(InlineArray1024_Int32);
		unchecked
		{
			if (num_syms == 0 || (uint)num_syms > 1024u)
			{
				return false;
			}
			int a = 0;
			int num = 0;
			int num2 = 0;
			for (int i = 0; (uint)i < (uint)num_syms; i++)
			{
				int num3 = (ushort)((short*)pFreq)[(uint)i];
				if (num3 == 0)
				{
					((sbyte*)pCodesizes)[(uint)i] = 0;
					continue;
				}
				num += num3;
				a = maximum_95ffuu.Invoke(a, num3);
				void* ptr = (byte*)(&((lzham_huffman_work_tables*)pContext)->syms0) + (nint)(uint)num2 * (nint)sizeof(lzham_sym_freq);
				((lzham_sym_freq*)ptr)->m_left = (short)i;
				((lzham_sym_freq*)ptr)->m_right = -1;
				((lzham_sym_freq*)ptr)->m_freq = num3;
				num2++;
			}
			*(int*)total_freq_ret = num;
			if (num2 == 1)
			{
				((sbyte*)pCodesizes)[(ushort)((lzham_sym_freq*)(&((lzham_huffman_work_tables*)pContext)->syms0))->m_left] = 1;
				return true;
			}
			void* ptr2 = radix_sort_syms.Invoke(syms1: &((lzham_huffman_work_tables*)pContext)->syms1, num_syms: num2, syms0: &((lzham_huffman_work_tables*)pContext)->syms0);
			for (int j = 0; (uint)j < (uint)num2; j++)
			{
				Unsafe.As<InlineArray1024_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray1024_Int, (nint)(uint)j * (nint)4)) = ((lzham_sym_freq*)ptr2)[(uint)j].m_freq;
			}
			calculate_minimum_redundancy.Invoke(&inlineArray1024_Int, num2);
			int num4 = 0;
			for (int k = 0; (uint)k < (uint)num2; k++)
			{
				int num5 = Unsafe.As<InlineArray1024_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray1024_Int, (nint)(uint)k * (nint)4));
				num4 = maximum_95ffuu.Invoke(num5, num4);
				((sbyte*)pCodesizes)[(ushort)((lzham_sym_freq*)ptr2)[(uint)k].m_left] = (sbyte)num5;
			}
			*(int*)max_code_size = num4;
			return true;
		}
	}
}
