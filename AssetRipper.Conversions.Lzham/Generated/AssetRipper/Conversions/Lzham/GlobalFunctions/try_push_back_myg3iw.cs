using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_push_back@?$vector@E@lzham@@QEAA_NAEBE@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_push_back(unsigned char const &)")]
[CleanName("try_push_back")]
internal static partial class try_push_back_myg3iw
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char const &")] void* obj)
	{
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_size >= (uint)((lzham_vector*)@this)->m_capacity)
			{
				bool flag = increase_capacity_hecp7w.Invoke(@this, ((lzham_vector*)@this)->m_size + 1, grow_hint: true, nofail: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			construct_ceg736.Invoke((byte*)((lzham_vector*)@this)->m_p + (uint)((lzham_vector*)@this)->m_size, obj);
			((lzham_vector*)@this)->m_size++;
			return true;
		}
	}
}
