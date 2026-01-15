using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_resize@?$vector@E@lzham@@QEAA_NI_N@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_resize(unsigned int, bool)")]
[CleanName("try_resize")]
internal static partial class try_resize_m9x9dy
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
					destruct_array_4eajvq.Invoke(n: ((lzham_vector*)@this)->m_size - new_size, p: (byte*)((lzham_vector*)@this)->m_p + (uint)new_size);
				}
				else
				{
					if ((uint)new_size > (uint)((lzham_vector*)@this)->m_capacity)
					{
						bool flag = increase_capacity_hecp7w.Invoke(@this, new_size, (new_size != ((lzham_vector*)@this)->m_size + 1) ? ((b & 1) == 1) : true, nofail: true);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_pnydps.Invoke(n: new_size - ((lzham_vector*)@this)->m_size, p: (byte*)((lzham_vector*)@this)->m_p + (uint)((lzham_vector*)@this)->m_size);
				}
				((lzham_vector*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
