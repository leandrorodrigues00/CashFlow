﻿using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infrastructure;

public static class DependecyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {


        services.AddScoped<IExpensesRepository, ExpensesRepository>();

    }
}
