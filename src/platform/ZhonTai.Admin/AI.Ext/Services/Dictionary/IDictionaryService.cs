﻿using ZhonTai.Admin.Core.Dto;
using System.Threading.Tasks; 
using ZhonTai.Admin.Domain.Dictionary.Dto;
using ZhonTai.Admin.Services.Dictionary.Dto;
using System.Collections.Generic;
namespace ZhonTai.Admin.Services.Dictionary;

/// <summary>
/// 数据字典接口
/// </summary>
public partial interface IDictioanryService
{
    Task<DictionaryGetOutput> GetAsync(long id); 
    Task<List<DictionaryListOutput>> GetListAsync(string name);
    Task<PageOutput<DictionaryListOutput>> GetPageAsync(PageInput<DictionaryGetPageDto> input);

    Task<long> AddAsync(DictionaryAddInput input);

    Task UpdateAsync(DictionaryUpdateInput input);

    Task DeleteAsync(long id);

    Task SoftDeleteAsync(long id);

    Task BatchSoftDeleteAsync(long[] ids);
}