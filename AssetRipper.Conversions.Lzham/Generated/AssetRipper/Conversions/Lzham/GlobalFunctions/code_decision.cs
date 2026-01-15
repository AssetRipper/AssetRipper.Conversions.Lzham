using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?code_decision@lzcompressor@lzham@@AEAA_NUlzdecision@12@AEAI1@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::code_decision(struct lzham::lzcompressor::lzdecision, unsigned int &, unsigned int &)")]
internal static partial class code_decision
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision")] void* lzdec, [NativeType("unsigned int &")] void* cur_ofs, [NativeType("unsigned int &")] void* bytes_to_match)
	{
		int num = Get_len_wzf5xk.Invoke(lzdec);
		unchecked
		{
			bool flag = encode_aguvmj.Invoke(&((lzham_lzcompressor*)@this)->field_16, dict: &((lzham_lzcompressor*)@this)->field_5, codec: &((lzham_lzcompressor*)@this)->field_6, lzbase: @this, lzdec: lzdec);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			*(int*)cur_ofs += num;
			*(int*)bytes_to_match -= num;
			advance_bytes.Invoke(&((lzham_lzcompressor*)@this)->field_5, num);
			((lzham_lzcompressor*)@this)->field_10++;
			return true;
		}
	}
}
