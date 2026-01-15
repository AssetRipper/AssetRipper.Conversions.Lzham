using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$queue_multiple_object_tasks@Vlzcompressor@lzham@@P812@EAAX_KPEAX@Z@task_pool@lzham@@QEAA_NPEAVlzcompressor@1@P821@EAAX_KPEAX@Z1I2@Z")]
[DemangledName("public: bool __cdecl lzham::task_pool::queue_multiple_object_tasks<class lzham::lzcompressor, void (__cdecl lzham::lzcompressor::*)(unsigned __int64, void *)>(class lzham::lzcompressor *, void (__cdecl lzham::lzcompressor::*)(unsigned __int64, void *), unsigned __int64, unsigned int, void *)")]
[CleanName("queue_multiple_object_tasks")]
internal static partial class queue_multiple_object_tasks_qegt6p
{
	public unsafe static bool Invoke(void* @this, void* pObject, void* pObject_method, long first_data, int num_tasks, void* pData_ptr)
	{
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_tasks; i++)
			{
				((delegate*<void*, long, void*, void>)pObject_method)(pObject, first_data + (uint)i, pData_ptr);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			return true;
		}
	}
}
