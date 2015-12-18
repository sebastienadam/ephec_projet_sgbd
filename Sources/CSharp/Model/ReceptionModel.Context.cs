﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjetSGBDEntities : DbContext
    {
        public ProjetSGBDEntities()
            : base("name=ProjetSGBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Feeling> Feeling { get; set; }
        public virtual DbSet<FeelingType> FeelingType { get; set; }
        public virtual DbSet<Reception> Reception { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<ReservedDish> ReservedDish { get; set; }
        public virtual DbSet<DishType> DishType { get; set; }
        public virtual DbSet<DishWish> DishWish { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<ReceptionAdmin> ReceptionAdmin { get; set; }
        public virtual DbSet<TablesMap> TablesMap { get; set; }
    
        public virtual int SP_VALIDATE_BOOK(Nullable<int> recId, Nullable<int> cliId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VALIDATE_BOOK", recIdParameter, cliIdParameter);
        }
    
        public virtual int SP_VALIDATE_RECEPTION(Nullable<int> recId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VALIDATE_RECEPTION", recIdParameter);
        }
    
        public virtual int SP_VALIDATE_TABLE(Nullable<int> tabId)
        {
            var tabIdParameter = tabId.HasValue ?
                new ObjectParameter("TabId", tabId) :
                new ObjectParameter("TabId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VALIDATE_TABLE", tabIdParameter);
        }
    
        public virtual int SP_DELETE_DISH_WISH(Nullable<int> cliId, Nullable<int> disId, Nullable<System.DateTime> modifiedAt)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_DISH_WISH", cliIdParameter, disIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_FEELING(Nullable<int> cliId, Nullable<int> cliCliId, Nullable<System.DateTime> modifiedAt)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var cliCliIdParameter = cliCliId.HasValue ?
                new ObjectParameter("CliCliId", cliCliId) :
                new ObjectParameter("CliCliId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_FEELING", cliIdParameter, cliCliIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_RESERVATION(Nullable<int> recId, Nullable<int> cliId, Nullable<System.DateTime> modifiedAt)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_RESERVATION", recIdParameter, cliIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_RESERVED_DISH(Nullable<int> cliId, Nullable<int> disId, Nullable<int> recId, Nullable<System.DateTime> modifiedAt)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_RESERVED_DISH", cliIdParameter, disIdParameter, recIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DISH_UNWISH(Nullable<int> cliId)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DISH_UNWISH", cliIdParameter);
        }
    
        public virtual int SP_DISH_WISH(Nullable<int> cliId, Nullable<int> ftyId)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DISH_WISH", cliIdParameter, ftyIdParameter);
        }
    
        public virtual ObjectResult<SP_FEELING_Result> SP_FEELING(Nullable<int> cliId, Nullable<int> ftyId)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_FEELING_Result>("SP_FEELING", cliIdParameter, ftyIdParameter);
        }
    
        public virtual int SP_MENU(Nullable<int> recId, Nullable<int> dtyId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var dtyIdParameter = dtyId.HasValue ?
                new ObjectParameter("DtyId", dtyId) :
                new ObjectParameter("DtyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MENU", recIdParameter, dtyIdParameter);
        }
    
        public virtual int SP_NEW_DISH_WISH(Nullable<int> cliId, Nullable<int> disId, Nullable<int> ftyId, string updateBy)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_DISH_WISH", cliIdParameter, disIdParameter, ftyIdParameter, updateByParameter);
        }
    
        public virtual int SP_NEW_FEELING(Nullable<int> cliId, Nullable<int> cliCliId, Nullable<int> ftyId, string updateBy)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var cliCliIdParameter = cliCliId.HasValue ?
                new ObjectParameter("CliCliId", cliCliId) :
                new ObjectParameter("CliCliId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_FEELING", cliIdParameter, cliCliIdParameter, ftyIdParameter, updateByParameter);
        }
    
        public virtual int SP_NEW_RESERVATION(Nullable<int> recId, Nullable<int> cliId, string updateBy)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_RESERVATION", recIdParameter, cliIdParameter, updateByParameter);
        }
    
        public virtual int SP_NEW_RESERVED_DISH(Nullable<int> cliId, Nullable<int> disId, Nullable<int> recId, string updateBy)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_RESERVED_DISH", cliIdParameter, disIdParameter, recIdParameter, updateByParameter);
        }
    
        public virtual ObjectResult<SP_RESERVATION_Result> SP_RESERVATION(Nullable<int> recId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RESERVATION_Result>("SP_RESERVATION", recIdParameter);
        }
    
        public virtual ObjectResult<SP_RESERVED_DISH_Result> SP_RESERVED_DISH(Nullable<int> recId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RESERVED_DISH_Result>("SP_RESERVED_DISH", recIdParameter);
        }
    
        public virtual int SP_TABLE_MAP(Nullable<int> recId, Nullable<int> tabId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var tabIdParameter = tabId.HasValue ?
                new ObjectParameter("TabId", tabId) :
                new ObjectParameter("TabId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_TABLE_MAP", recIdParameter, tabIdParameter);
        }
    
        public virtual ObjectResult<SP_UNFEELING_Result> SP_UNFEELING(Nullable<int> cliId)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_UNFEELING_Result>("SP_UNFEELING", cliIdParameter);
        }
    
        public virtual ObjectResult<SP_UNRESERVATION_Result> SP_UNRESERVATION(Nullable<int> cliId)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_UNRESERVATION_Result>("SP_UNRESERVATION", cliIdParameter);
        }
    
        public virtual int SP_UPDATE_DISH_WISH(Nullable<int> cliId, Nullable<int> disId, Nullable<int> ftyId, Nullable<System.DateTime> modifiedAt)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_DISH_WISH", cliIdParameter, disIdParameter, ftyIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_UPDATE_FEELING(Nullable<int> cliId, Nullable<int> cliCliId, Nullable<int> ftyId, Nullable<System.DateTime> modifiedAt)
        {
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var cliCliIdParameter = cliCliId.HasValue ?
                new ObjectParameter("CliCliId", cliCliId) :
                new ObjectParameter("CliCliId", typeof(int));
    
            var ftyIdParameter = ftyId.HasValue ?
                new ObjectParameter("FtyId", ftyId) :
                new ObjectParameter("FtyId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_FEELING", cliIdParameter, cliCliIdParameter, ftyIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_MENU(Nullable<int> recId, Nullable<int> disId, Nullable<System.DateTime> modifiedAt)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_MENU", recIdParameter, disIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_SIT(Nullable<int> tabId, Nullable<int> cliId, Nullable<System.DateTime> modifiedAt)
        {
            var tabIdParameter = tabId.HasValue ?
                new ObjectParameter("TabId", tabId) :
                new ObjectParameter("TabId", typeof(int));
    
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_SIT", tabIdParameter, cliIdParameter, modifiedAtParameter);
        }
    
        public virtual int SP_DELETE_TABLE(Nullable<int> tabId, Nullable<System.DateTime> modifiedAt)
        {
            var tabIdParameter = tabId.HasValue ?
                new ObjectParameter("TabId", tabId) :
                new ObjectParameter("TabId", typeof(int));
    
            var modifiedAtParameter = modifiedAt.HasValue ?
                new ObjectParameter("ModifiedAt", modifiedAt) :
                new ObjectParameter("ModifiedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_TABLE", tabIdParameter, modifiedAtParameter);
        }
    
        public virtual ObjectResult<SP_DISHES_TO_PREPARE_Result> SP_DISHES_TO_PREPARE(Nullable<int> recId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DISHES_TO_PREPARE_Result>("SP_DISHES_TO_PREPARE", recIdParameter);
        }
    
        public virtual int SP_NEW_MENU(Nullable<int> recId, Nullable<int> disId, string updateBy)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var disIdParameter = disId.HasValue ?
                new ObjectParameter("DisId", disId) :
                new ObjectParameter("DisId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_MENU", recIdParameter, disIdParameter, updateByParameter);
        }
    
        public virtual int SP_NEW_SIT(Nullable<int> tabId, Nullable<int> cliId, string updateBy)
        {
            var tabIdParameter = tabId.HasValue ?
                new ObjectParameter("TabId", tabId) :
                new ObjectParameter("TabId", typeof(int));
    
            var cliIdParameter = cliId.HasValue ?
                new ObjectParameter("CliId", cliId) :
                new ObjectParameter("CliId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_SIT", tabIdParameter, cliIdParameter, updateByParameter);
        }
    
        public virtual int SP_NEW_TABLE(Nullable<int> recId, string updateBy, ObjectParameter tabId)
        {
            var recIdParameter = recId.HasValue ?
                new ObjectParameter("RecId", recId) :
                new ObjectParameter("RecId", typeof(int));
    
            var updateByParameter = updateBy != null ?
                new ObjectParameter("UpdateBy", updateBy) :
                new ObjectParameter("UpdateBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NEW_TABLE", recIdParameter, updateByParameter, tabId);
        }
    }
}
