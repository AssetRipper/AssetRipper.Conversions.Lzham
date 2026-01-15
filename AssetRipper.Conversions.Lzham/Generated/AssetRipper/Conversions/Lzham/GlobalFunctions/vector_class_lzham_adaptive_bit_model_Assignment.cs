using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class lzham::vector<class lzham::adaptive_bit_model> & __cdecl lzham::vector<class lzham::adaptive_bit_model>::operator=(class lzham::vector<class lzham::adaptive_bit_model> const &)")]
internal static partial class vector_class_lzham_adaptive_bit_model_Assignment
{
	[return: NativeType("class lzham::vector<class lzham::adaptive_bit_model> &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::vector<class lzham::adaptive_bit_model> const &")] void* other)
	{
		if (@this == other)
		{
			return @this;
		}
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_capacity >= (uint)((lzham_vector*)other)->m_size)
			{
				try_resize_dw23aw.Invoke(@this, 0, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
			}
			else
			{
				clear_hqamxp.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				bool flag = increase_capacity_ggkcfn.Invoke(@this, ((lzham_vector*)other)->m_size, grow_hint: false, nofail: false);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				if (!flag)
				{
					lzham_fail.Invoke(String_e4f6vd.__pointer, String_cn9etx.__pointer, 96);
					return @this;
				}
			}
			void* ptr = ((lzham_vector*)@this)->m_p;
			void* ptr2 = ((lzham_vector*)other)->m_p;
			for (int i = ((lzham_vector*)other)->m_size; i != 0; i += -1)
			{
				void* ptr3 = ptr2;
				ptr2 = (byte*)ptr3 + sizeof(lzham_adaptive_bit_model);
				void* ptr4 = ptr;
				ptr = (byte*)ptr4 + sizeof(lzham_adaptive_bit_model);
				construct_nx5w3v.Invoke(ptr4, ptr3);
			}
			((lzham_vector*)@this)->m_size = ((lzham_vector*)other)->m_size;
			return @this;
		}
	}
}
