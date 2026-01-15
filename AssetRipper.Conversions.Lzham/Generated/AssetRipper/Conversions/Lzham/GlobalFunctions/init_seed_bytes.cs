using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init_seed_bytes@lzcompressor@lzham@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::init_seed_bytes(void)")]
internal static partial class init_seed_bytes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			int num;
			for (int i = 0; (uint)i < (uint)((lzham_lzcompressor*)@this)->field_1.m_num_seed_bytes; i += num)
			{
				num = minimum_c94n3m.Invoke(((lzham_lzcompressor*)@this)->field_1.m_num_seed_bytes - i, ((lzham_lzcompressor*)@this)->field_1.m_block_size);
				bool flag = add_bytes_begin.Invoke(&((lzham_lzcompressor*)@this)->field_5, num, (byte*)((lzham_lzcompressor*)@this)->field_1.m_pSeed_bytes + (uint)i);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
				add_bytes_end.Invoke(&((lzham_lzcompressor*)@this)->field_5);
				advance_bytes.Invoke(&((lzham_lzcompressor*)@this)->field_5, num);
			}
			return true;
		}
	}
}
