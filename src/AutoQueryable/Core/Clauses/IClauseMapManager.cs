﻿using AutoQueryable.Core.Enums;
using AutoQueryable.Core.Models;

namespace AutoQueryable.Core.Clauses
{
    public interface IClauseMapManager
    {
        IClauseQueryFilter FindClauseQueryFilter(string queryParameterKey);
        IClauseQueryFilter GetClauseQueryFilter(string alias);
        IClauseQueryFilter GetClauseQueryFilter(ClauseType clauseType);
    }
}