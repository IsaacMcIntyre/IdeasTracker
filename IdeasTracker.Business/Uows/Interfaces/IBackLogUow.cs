﻿using System.Collections.Generic;
using System.Threading.Tasks;
using IdeasTracker.Models;

namespace IdeasTracker.Business.Uows.Interfaces
{
    public interface IBackLogUow
    {
        Task<List<BacklogModel>> GetAllBackLogItemsAsync();
        Task<BacklogModel> GetBackLogItemAsync(int? id);
        Task EditBackLogItemAsync(BacklogModel backlogModel);
        Task CreateBackLogItemAsync(CreateIdeaModel createIdeaModel);
        Task AdoptIdeaAsync(AdoptRequestModel adoptRequestModel, string userEmail);
        Task DeleteBackLogItem(int? id);
        Task<bool> IsBackLogItemExistsAsync(int id);
        Task AcceptAdoption(AdoptRequestModel adoptRequestModel, string userEmail);
        Task RejectAdoption(AdoptRequestModel adoptRequestModel, string userEmail);
        Task<(byte[], string)> ExportBacklog();
        Task<AdoptRequestModel> GetBackLogAdoptableItem(int? id);

    }
}
