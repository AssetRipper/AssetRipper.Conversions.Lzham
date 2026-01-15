using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_resize@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAA_NI_N@Z")]
[DemangledName("public: bool __cdecl lzham::vector<class lzham::adaptive_bit_model>::try_resize(unsigned int, bool)")]
[CleanName("try_resize")]
internal static partial class try_resize_dw23aw
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		sbyte b = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if (((lzham_vector*)@this)->m_size != new_size)
			{
				if ((uint)new_size < (uint)((lzham_vector*)@this)->m_size)
				{
					destruct_array_dwzwyb.Invoke(n: ((lzham_vector*)@this)->m_size - new_size, p: (byte*)((lzham_vector*)@this)->m_p + (nint)(uint)new_size * (nint)sizeof(lzham_adaptive_bit_model));
				}
				else
				{
					if ((uint)new_size > (uint)((lzham_vector*)@this)->m_capacity)
					{
						bool flag = increase_capacity_ggkcfn.Invoke(@this, new_size, (new_size != ((lzham_vector*)@this)->m_size + 1) ? ((b & 1) == 1) : true, nofail: true);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_3x49nx.Invoke(n: new_size - ((lzham_vector*)@this)->m_size, p: (byte*)((lzham_vector*)@this)->m_p + (nint)(uint)((lzham_vector*)@this)->m_size * (nint)sizeof(lzham_adaptive_bit_model));
				}
				((lzham_vector*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
