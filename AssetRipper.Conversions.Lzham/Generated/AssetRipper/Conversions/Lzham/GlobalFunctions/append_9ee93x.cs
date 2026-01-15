using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?append@?$vector@E@lzham@@QEAA_NAEBV12@@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::append(class lzham::vector<unsigned char> const &)")]
[CleanName("append")]
internal static partial class append_9ee93x
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class lzham::vector<unsigned char> const &")] void* other)
	{
		unchecked
		{
			if (((lzham_vector*)other)->m_size != 0)
			{
				bool result = insert.Invoke(n: ((lzham_vector*)other)->m_size, p: vector_unsigned_char_Operator_7ma9vz.Invoke(other, 0), @this: @this, index: ((lzham_vector*)@this)->m_size);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				return result;
			}
			return true;
		}
	}
}
