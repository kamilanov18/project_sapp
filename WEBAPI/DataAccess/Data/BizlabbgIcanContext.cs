using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public partial class BizlabbgIcanContext : DbContext
{
    public BizlabbgIcanContext()
    {
    }

    public BizlabbgIcanContext(DbContextOptions<BizlabbgIcanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IcaksActionschedulerAction> IcaksActionschedulerActions { get; set; }

    public virtual DbSet<IcaksActionschedulerClaim> IcaksActionschedulerClaims { get; set; }

    public virtual DbSet<IcaksActionschedulerGroup> IcaksActionschedulerGroups { get; set; }

    public virtual DbSet<IcaksActionschedulerLog> IcaksActionschedulerLogs { get; set; }

    public virtual DbSet<IcaksAmeliaAppointment> IcaksAmeliaAppointments { get; set; }

    public virtual DbSet<IcaksAmeliaCache> IcaksAmeliaCaches { get; set; }

    public virtual DbSet<IcaksAmeliaCategory> IcaksAmeliaCategories { get; set; }

    public virtual DbSet<IcaksAmeliaCoupon> IcaksAmeliaCoupons { get; set; }

    public virtual DbSet<IcaksAmeliaCouponsToEvent> IcaksAmeliaCouponsToEvents { get; set; }

    public virtual DbSet<IcaksAmeliaCouponsToPackage> IcaksAmeliaCouponsToPackages { get; set; }

    public virtual DbSet<IcaksAmeliaCouponsToService> IcaksAmeliaCouponsToServices { get; set; }

    public virtual DbSet<IcaksAmeliaCustomField> IcaksAmeliaCustomFields { get; set; }

    public virtual DbSet<IcaksAmeliaCustomFieldsEvent> IcaksAmeliaCustomFieldsEvents { get; set; }

    public virtual DbSet<IcaksAmeliaCustomFieldsOption> IcaksAmeliaCustomFieldsOptions { get; set; }

    public virtual DbSet<IcaksAmeliaCustomFieldsService> IcaksAmeliaCustomFieldsServices { get; set; }

    public virtual DbSet<IcaksAmeliaCustomerBooking> IcaksAmeliaCustomerBookings { get; set; }

    public virtual DbSet<IcaksAmeliaCustomerBookingsToEventsPeriod> IcaksAmeliaCustomerBookingsToEventsPeriods { get; set; }

    public virtual DbSet<IcaksAmeliaCustomerBookingsToEventsTicket> IcaksAmeliaCustomerBookingsToEventsTickets { get; set; }

    public virtual DbSet<IcaksAmeliaCustomerBookingsToExtra> IcaksAmeliaCustomerBookingsToExtras { get; set; }

    public virtual DbSet<IcaksAmeliaEvent> IcaksAmeliaEvents { get; set; }

    public virtual DbSet<IcaksAmeliaEventsPeriod> IcaksAmeliaEventsPeriods { get; set; }

    public virtual DbSet<IcaksAmeliaEventsTag> IcaksAmeliaEventsTags { get; set; }

    public virtual DbSet<IcaksAmeliaEventsToProvider> IcaksAmeliaEventsToProviders { get; set; }

    public virtual DbSet<IcaksAmeliaEventsToTicket> IcaksAmeliaEventsToTickets { get; set; }

    public virtual DbSet<IcaksAmeliaExtra> IcaksAmeliaExtras { get; set; }

    public virtual DbSet<IcaksAmeliaGallery> IcaksAmeliaGalleries { get; set; }

    public virtual DbSet<IcaksAmeliaLocation> IcaksAmeliaLocations { get; set; }

    public virtual DbSet<IcaksAmeliaLocationsView> IcaksAmeliaLocationsViews { get; set; }

    public virtual DbSet<IcaksAmeliaNotification> IcaksAmeliaNotifications { get; set; }

    public virtual DbSet<IcaksAmeliaNotificationsLog> IcaksAmeliaNotificationsLogs { get; set; }

    public virtual DbSet<IcaksAmeliaNotificationsSmsHistory> IcaksAmeliaNotificationsSmsHistories { get; set; }

    public virtual DbSet<IcaksAmeliaNotificationsToEntity> IcaksAmeliaNotificationsToEntities { get; set; }

    public virtual DbSet<IcaksAmeliaPackage> IcaksAmeliaPackages { get; set; }

    public virtual DbSet<IcaksAmeliaPackagesCustomersToService> IcaksAmeliaPackagesCustomersToServices { get; set; }

    public virtual DbSet<IcaksAmeliaPackagesServicesToLocation> IcaksAmeliaPackagesServicesToLocations { get; set; }

    public virtual DbSet<IcaksAmeliaPackagesServicesToProvider> IcaksAmeliaPackagesServicesToProviders { get; set; }

    public virtual DbSet<IcaksAmeliaPackagesToCustomer> IcaksAmeliaPackagesToCustomers { get; set; }

    public virtual DbSet<IcaksAmeliaPackagesToService> IcaksAmeliaPackagesToServices { get; set; }

    public virtual DbSet<IcaksAmeliaPayment> IcaksAmeliaPayments { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToDaysoff> IcaksAmeliaProvidersToDaysoffs { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToGoogleCalendar> IcaksAmeliaProvidersToGoogleCalendars { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToLocation> IcaksAmeliaProvidersToLocations { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToOutlookCalendar> IcaksAmeliaProvidersToOutlookCalendars { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToPeriod> IcaksAmeliaProvidersToPeriods { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToPeriodsLocation> IcaksAmeliaProvidersToPeriodsLocations { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToPeriodsService> IcaksAmeliaProvidersToPeriodsServices { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToService> IcaksAmeliaProvidersToServices { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToSpecialday> IcaksAmeliaProvidersToSpecialdays { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToSpecialdaysPeriod> IcaksAmeliaProvidersToSpecialdaysPeriods { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToSpecialdaysPeriodsLocation> IcaksAmeliaProvidersToSpecialdaysPeriodsLocations { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToSpecialdaysPeriodsService> IcaksAmeliaProvidersToSpecialdaysPeriodsServices { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToTimeout> IcaksAmeliaProvidersToTimeouts { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersToWeekday> IcaksAmeliaProvidersToWeekdays { get; set; }

    public virtual DbSet<IcaksAmeliaProvidersView> IcaksAmeliaProvidersViews { get; set; }

    public virtual DbSet<IcaksAmeliaResource> IcaksAmeliaResources { get; set; }

    public virtual DbSet<IcaksAmeliaResourcesToEntity> IcaksAmeliaResourcesToEntities { get; set; }

    public virtual DbSet<IcaksAmeliaService> IcaksAmeliaServices { get; set; }

    public virtual DbSet<IcaksAmeliaServicesView> IcaksAmeliaServicesViews { get; set; }

    public virtual DbSet<IcaksAmeliaUser> IcaksAmeliaUsers { get; set; }

    public virtual DbSet<IcaksAutomatorwpAction> IcaksAutomatorwpActions { get; set; }

    public virtual DbSet<IcaksAutomatorwpActionsMetum> IcaksAutomatorwpActionsMeta { get; set; }

    public virtual DbSet<IcaksAutomatorwpAutomation> IcaksAutomatorwpAutomations { get; set; }

    public virtual DbSet<IcaksAutomatorwpAutomationsMetum> IcaksAutomatorwpAutomationsMeta { get; set; }

    public virtual DbSet<IcaksAutomatorwpLog> IcaksAutomatorwpLogs { get; set; }

    public virtual DbSet<IcaksAutomatorwpLogsMetum> IcaksAutomatorwpLogsMeta { get; set; }

    public virtual DbSet<IcaksAutomatorwpTrigger> IcaksAutomatorwpTriggers { get; set; }

    public virtual DbSet<IcaksAutomatorwpTriggersMetum> IcaksAutomatorwpTriggersMeta { get; set; }

    public virtual DbSet<IcaksBwfAbExperiment> IcaksBwfAbExperiments { get; set; }

    public virtual DbSet<IcaksBwfAction> IcaksBwfActions { get; set; }

    public virtual DbSet<IcaksBwfActionClaim> IcaksBwfActionClaims { get; set; }

    public virtual DbSet<IcaksBwfContact> IcaksBwfContacts { get; set; }

    public virtual DbSet<IcaksBwfContactMetum> IcaksBwfContactMeta { get; set; }

    public virtual DbSet<IcaksBwfConversionTracking> IcaksBwfConversionTrackings { get; set; }

    public virtual DbSet<IcaksBwfFunnel> IcaksBwfFunnels { get; set; }

    public virtual DbSet<IcaksBwfFunnelmetum> IcaksBwfFunnelmeta { get; set; }

    public virtual DbSet<IcaksBwfOptinEntry> IcaksBwfOptinEntries { get; set; }

    public virtual DbSet<IcaksBwfOption> IcaksBwfOptions { get; set; }

    public virtual DbSet<IcaksBwfWcCustomer> IcaksBwfWcCustomers { get; set; }

    public virtual DbSet<IcaksBwfanAbandonedcart> IcaksBwfanAbandonedcarts { get; set; }

    public virtual DbSet<IcaksBwfanAutomation> IcaksBwfanAutomations { get; set; }

    public virtual DbSet<IcaksBwfanAutomationCompleteContact> IcaksBwfanAutomationCompleteContacts { get; set; }

    public virtual DbSet<IcaksBwfanAutomationContact> IcaksBwfanAutomationContacts { get; set; }

    public virtual DbSet<IcaksBwfanAutomationContactClaim> IcaksBwfanAutomationContactClaims { get; set; }

    public virtual DbSet<IcaksBwfanAutomationContactTrail> IcaksBwfanAutomationContactTrails { get; set; }

    public virtual DbSet<IcaksBwfanAutomationStep> IcaksBwfanAutomationSteps { get; set; }

    public virtual DbSet<IcaksBwfanAutomationmetum> IcaksBwfanAutomationmeta { get; set; }

    public virtual DbSet<IcaksBwfanMessageUnsubscribe> IcaksBwfanMessageUnsubscribes { get; set; }

    public virtual DbSet<IcaksCartbounty> IcaksCartbounties { get; set; }

    public virtual DbSet<IcaksComment> IcaksComments { get; set; }

    public virtual DbSet<IcaksCommentmetum> IcaksCommentmeta { get; set; }

    public virtual DbSet<IcaksEEvent> IcaksEEvents { get; set; }

    public virtual DbSet<IcaksFkCartStat> IcaksFkCartStats { get; set; }

    public virtual DbSet<IcaksLink> IcaksLinks { get; set; }

    public virtual DbSet<IcaksOption> IcaksOptions { get; set; }

    public virtual DbSet<IcaksPost> IcaksPosts { get; set; }

    public virtual DbSet<IcaksPostmetum> IcaksPostmeta { get; set; }

    public virtual DbSet<IcaksTecEvent> IcaksTecEvents { get; set; }

    public virtual DbSet<IcaksTecOccurrence> IcaksTecOccurrences { get; set; }

    public virtual DbSet<IcaksTerm> IcaksTerms { get; set; }

    public virtual DbSet<IcaksTermRelationship> IcaksTermRelationships { get; set; }

    public virtual DbSet<IcaksTermTaxonomy> IcaksTermTaxonomies { get; set; }

    public virtual DbSet<IcaksTermmetum> IcaksTermmeta { get; set; }

    public virtual DbSet<IcaksTutorEarning> IcaksTutorEarnings { get; set; }

    public virtual DbSet<IcaksTutorQuizAttempt> IcaksTutorQuizAttempts { get; set; }

    public virtual DbSet<IcaksTutorQuizAttemptAnswer> IcaksTutorQuizAttemptAnswers { get; set; }

    public virtual DbSet<IcaksTutorQuizQuestion> IcaksTutorQuizQuestions { get; set; }

    public virtual DbSet<IcaksTutorQuizQuestionAnswer> IcaksTutorQuizQuestionAnswers { get; set; }

    public virtual DbSet<IcaksTutorWithdraw> IcaksTutorWithdraws { get; set; }

    public virtual DbSet<IcaksUser> IcaksUsers { get; set; }

    public virtual DbSet<IcaksUsermetum> IcaksUsermeta { get; set; }

    public virtual DbSet<IcaksWcAdminNote> IcaksWcAdminNotes { get; set; }

    public virtual DbSet<IcaksWcAdminNoteAction> IcaksWcAdminNoteActions { get; set; }

    public virtual DbSet<IcaksWcCategoryLookup> IcaksWcCategoryLookups { get; set; }

    public virtual DbSet<IcaksWcCustomerLookup> IcaksWcCustomerLookups { get; set; }

    public virtual DbSet<IcaksWcDownloadLog> IcaksWcDownloadLogs { get; set; }

    public virtual DbSet<IcaksWcOrder> IcaksWcOrders { get; set; }

    public virtual DbSet<IcaksWcOrderAddress> IcaksWcOrderAddresses { get; set; }

    public virtual DbSet<IcaksWcOrderCouponLookup> IcaksWcOrderCouponLookups { get; set; }

    public virtual DbSet<IcaksWcOrderOperationalDatum> IcaksWcOrderOperationalData { get; set; }

    public virtual DbSet<IcaksWcOrderProductLookup> IcaksWcOrderProductLookups { get; set; }

    public virtual DbSet<IcaksWcOrderStat> IcaksWcOrderStats { get; set; }

    public virtual DbSet<IcaksWcOrderTaxLookup> IcaksWcOrderTaxLookups { get; set; }

    public virtual DbSet<IcaksWcOrdersMetum> IcaksWcOrdersMeta { get; set; }

    public virtual DbSet<IcaksWcProductAttributesLookup> IcaksWcProductAttributesLookups { get; set; }

    public virtual DbSet<IcaksWcProductDownloadDirectory> IcaksWcProductDownloadDirectories { get; set; }

    public virtual DbSet<IcaksWcProductMetaLookup> IcaksWcProductMetaLookups { get; set; }

    public virtual DbSet<IcaksWcRateLimit> IcaksWcRateLimits { get; set; }

    public virtual DbSet<IcaksWcReservedStock> IcaksWcReservedStocks { get; set; }

    public virtual DbSet<IcaksWcTaxRateClass> IcaksWcTaxRateClasses { get; set; }

    public virtual DbSet<IcaksWcWebhook> IcaksWcWebhooks { get; set; }

    public virtual DbSet<IcaksWfacpStat> IcaksWfacpStats { get; set; }

    public virtual DbSet<IcaksWfcoConnector> IcaksWfcoConnectors { get; set; }

    public virtual DbSet<IcaksWfcoConnectormetum> IcaksWfcoConnectormeta { get; set; }

    public virtual DbSet<IcaksWfcoReportView> IcaksWfcoReportViews { get; set; }

    public virtual DbSet<IcaksWfobStat> IcaksWfobStats { get; set; }

    public virtual DbSet<IcaksWfocuEvent> IcaksWfocuEvents { get; set; }

    public virtual DbSet<IcaksWfocuEventMetum> IcaksWfocuEventMeta { get; set; }

    public virtual DbSet<IcaksWfocuSession> IcaksWfocuSessions { get; set; }

    public virtual DbSet<IcaksWoocommerceApiKey> IcaksWoocommerceApiKeys { get; set; }

    public virtual DbSet<IcaksWoocommerceAttributeTaxonomy> IcaksWoocommerceAttributeTaxonomies { get; set; }

    public virtual DbSet<IcaksWoocommerceDownloadableProductPermission> IcaksWoocommerceDownloadableProductPermissions { get; set; }

    public virtual DbSet<IcaksWoocommerceLog> IcaksWoocommerceLogs { get; set; }

    public virtual DbSet<IcaksWoocommerceOrderItem> IcaksWoocommerceOrderItems { get; set; }

    public virtual DbSet<IcaksWoocommerceOrderItemmetum> IcaksWoocommerceOrderItemmeta { get; set; }

    public virtual DbSet<IcaksWoocommercePaymentToken> IcaksWoocommercePaymentTokens { get; set; }

    public virtual DbSet<IcaksWoocommercePaymentTokenmetum> IcaksWoocommercePaymentTokenmeta { get; set; }

    public virtual DbSet<IcaksWoocommerceSession> IcaksWoocommerceSessions { get; set; }

    public virtual DbSet<IcaksWoocommerceShippingZone> IcaksWoocommerceShippingZones { get; set; }

    public virtual DbSet<IcaksWoocommerceShippingZoneLocation> IcaksWoocommerceShippingZoneLocations { get; set; }

    public virtual DbSet<IcaksWoocommerceShippingZoneMethod> IcaksWoocommerceShippingZoneMethods { get; set; }

    public virtual DbSet<IcaksWoocommerceTaxRate> IcaksWoocommerceTaxRates { get; set; }

    public virtual DbSet<IcaksWoocommerceTaxRateLocation> IcaksWoocommerceTaxRateLocations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;port=3306;database=bizlabbg_ican;uid=asdf;pwd=asdf;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IcaksActionschedulerAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.ToTable("icaks_actionscheduler_actions");

            entity.HasIndex(e => e.Args, "args");

            entity.HasIndex(e => new { e.ClaimId, e.Status, e.ScheduledDateGmt }, "claim_id_status_scheduled_date_gmt");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.Hook, "hook");

            entity.HasIndex(e => e.LastAttemptGmt, "last_attempt_gmt");

            entity.HasIndex(e => e.ScheduledDateGmt, "scheduled_date_gmt");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.Args)
                .HasMaxLength(191)
                .HasColumnName("args");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.ClaimId).HasColumnName("claim_id");
            entity.Property(e => e.ExtendedArgs)
                .HasMaxLength(8000)
                .HasColumnName("extended_args");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Hook)
                .HasMaxLength(191)
                .HasColumnName("hook");
            entity.Property(e => e.LastAttemptGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("last_attempt_gmt");
            entity.Property(e => e.LastAttemptLocal)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("last_attempt_local");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'10'")
                .HasColumnName("priority");
            entity.Property(e => e.Schedule).HasColumnName("schedule");
            entity.Property(e => e.ScheduledDateGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("scheduled_date_gmt");
            entity.Property(e => e.ScheduledDateLocal)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("scheduled_date_local");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksActionschedulerClaim>(entity =>
        {
            entity.HasKey(e => e.ClaimId).HasName("PRIMARY");

            entity.ToTable("icaks_actionscheduler_claims");

            entity.HasIndex(e => e.DateCreatedGmt, "date_created_gmt");

            entity.Property(e => e.ClaimId).HasColumnName("claim_id");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
        });

        modelBuilder.Entity<IcaksActionschedulerGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.ToTable("icaks_actionscheduler_groups");

            entity.HasIndex(e => e.Slug, "slug");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Slug).HasColumnName("slug");
        });

        modelBuilder.Entity<IcaksActionschedulerLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("icaks_actionscheduler_logs");

            entity.HasIndex(e => e.ActionId, "action_id");

            entity.HasIndex(e => e.LogDateGmt, "log_date_gmt");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.LogDateGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("log_date_gmt");
            entity.Property(e => e.LogDateLocal)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("log_date_local");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
        });

        modelBuilder.Entity<IcaksAmeliaAppointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_appointments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingEnd)
                .HasColumnType("datetime")
                .HasColumnName("bookingEnd");
            entity.Property(e => e.BookingStart)
                .HasColumnType("datetime")
                .HasColumnName("bookingStart");
            entity.Property(e => e.GoogleCalendarEventId)
                .HasMaxLength(255)
                .HasColumnName("googleCalendarEventId");
            entity.Property(e => e.GoogleMeetUrl)
                .HasMaxLength(255)
                .HasColumnName("googleMeetUrl");
            entity.Property(e => e.InternalNotes)
                .HasColumnType("text")
                .HasColumnName("internalNotes");
            entity.Property(e => e.LessonSpace)
                .HasColumnType("text")
                .HasColumnName("lessonSpace");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.NotifyParticipants).HasColumnName("notifyParticipants");
            entity.Property(e => e.OutlookCalendarEventId)
                .HasMaxLength(255)
                .HasColumnName("outlookCalendarEventId");
            entity.Property(e => e.PackageId).HasColumnName("packageId");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.ProviderId).HasColumnName("providerId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Status)
                .HasColumnType("enum('approved','pending','canceled','rejected','no-show')")
                .HasColumnName("status");
            entity.Property(e => e.ZoomMeeting)
                .HasColumnType("text")
                .HasColumnName("zoomMeeting");
        });

        modelBuilder.Entity<IcaksAmeliaCache>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_cache");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PaymentId).HasColumnName("paymentId");
        });

        modelBuilder.Entity<IcaksAmeliaCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasDefaultValueSql("'#1788FB'")
                .HasColumnName("color");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaCoupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_coupons");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CustomerLimit).HasColumnName("customerLimit");
            entity.Property(e => e.Deduction).HasColumnName("deduction");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("expirationDate");
            entity.Property(e => e.Limit).HasColumnName("limit");
            entity.Property(e => e.NotificationInterval).HasColumnName("notificationInterval");
            entity.Property(e => e.NotificationRecurring).HasColumnName("notificationRecurring");
            entity.Property(e => e.Status)
                .HasColumnType("enum('hidden','visible')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksAmeliaCouponsToEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_coupons_to_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CouponId).HasColumnName("couponId");
            entity.Property(e => e.EventId).HasColumnName("eventId");
        });

        modelBuilder.Entity<IcaksAmeliaCouponsToPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_coupons_to_packages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CouponId).HasColumnName("couponId");
            entity.Property(e => e.PackageId).HasColumnName("packageId");
        });

        modelBuilder.Entity<IcaksAmeliaCouponsToService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_coupons_to_services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CouponId).HasColumnName("couponId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaCustomField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_custom_fields");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllEvents).HasColumnName("allEvents");
            entity.Property(e => e.AllServices).HasColumnName("allServices");
            entity.Property(e => e.Label)
                .HasColumnType("text")
                .HasColumnName("label");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'text'")
                .HasColumnType("enum('text','text-area','select','checkbox','radio','content','file','datepicker','address')")
                .HasColumnName("type");
            entity.Property(e => e.UseAsLocation).HasColumnName("useAsLocation");
        });

        modelBuilder.Entity<IcaksAmeliaCustomFieldsEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_custom_fields_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomFieldId).HasColumnName("customFieldId");
            entity.Property(e => e.EventId).HasColumnName("eventId");
        });

        modelBuilder.Entity<IcaksAmeliaCustomFieldsOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_custom_fields_options");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomFieldId).HasColumnName("customFieldId");
            entity.Property(e => e.Label)
                .HasColumnType("text")
                .HasColumnName("label");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaCustomFieldsService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_custom_fields_services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomFieldId).HasColumnName("customFieldId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaCustomerBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_customer_bookings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionsCompleted).HasColumnName("actionsCompleted");
            entity.Property(e => e.AggregatedPrice)
                .HasDefaultValueSql("'1'")
                .HasColumnName("aggregatedPrice");
            entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");
            entity.Property(e => e.CouponId).HasColumnName("couponId");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CustomFields)
                .HasColumnType("text")
                .HasColumnName("customFields");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Info)
                .HasColumnType("text")
                .HasColumnName("info");
            entity.Property(e => e.PackageCustomerServiceId).HasColumnName("packageCustomerServiceId");
            entity.Property(e => e.Persons).HasColumnName("persons");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Status)
                .HasColumnType("enum('approved','pending','canceled','rejected','no-show')")
                .HasColumnName("status");
            entity.Property(e => e.Token)
                .HasMaxLength(10)
                .HasColumnName("token");
            entity.Property(e => e.UtcOffset).HasColumnName("utcOffset");
        });

        modelBuilder.Entity<IcaksAmeliaCustomerBookingsToEventsPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_customer_bookings_to_events_periods");

            entity.HasIndex(e => new { e.CustomerBookingId, e.EventPeriodId }, "bookingEventPeriod").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerBookingId).HasColumnName("customerBookingId");
            entity.Property(e => e.EventPeriodId).HasColumnName("eventPeriodId");
        });

        modelBuilder.Entity<IcaksAmeliaCustomerBookingsToEventsTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_customer_bookings_to_events_tickets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerBookingId).HasColumnName("customerBookingId");
            entity.Property(e => e.EventTicketId).HasColumnName("eventTicketId");
            entity.Property(e => e.Persons).HasColumnName("persons");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("price");
        });

        modelBuilder.Entity<IcaksAmeliaCustomerBookingsToExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_customer_bookings_to_extras");

            entity.HasIndex(e => new { e.CustomerBookingId, e.ExtraId }, "bookingExtra").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AggregatedPrice).HasColumnName("aggregatedPrice");
            entity.Property(e => e.CustomerBookingId).HasColumnName("customerBookingId");
            entity.Property(e => e.ExtraId).HasColumnName("extraId");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        modelBuilder.Entity<IcaksAmeliaEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AggregatedPrice)
                .HasDefaultValueSql("'1'")
                .HasColumnName("aggregatedPrice");
            entity.Property(e => e.BookMultipleTimes)
                .HasDefaultValueSql("'1'")
                .HasColumnName("bookMultipleTimes");
            entity.Property(e => e.BookingCloses)
                .HasColumnType("datetime")
                .HasColumnName("bookingCloses");
            entity.Property(e => e.BookingClosesRec)
                .HasDefaultValueSql("'same'")
                .HasColumnType("enum('same','calculate')")
                .HasColumnName("bookingClosesRec");
            entity.Property(e => e.BookingOpens)
                .HasColumnType("datetime")
                .HasColumnName("bookingOpens");
            entity.Property(e => e.BookingOpensRec)
                .HasDefaultValueSql("'same'")
                .HasColumnType("enum('same','calculate')")
                .HasColumnName("bookingOpensRec");
            entity.Property(e => e.BringingAnyone)
                .HasDefaultValueSql("'1'")
                .HasColumnName("bringingAnyone");
            entity.Property(e => e.CloseAfterMin).HasColumnName("closeAfterMin");
            entity.Property(e => e.CloseAfterMinBookings)
                .HasDefaultValueSql("'0'")
                .HasColumnName("closeAfterMinBookings");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CustomLocation)
                .HasMaxLength(255)
                .HasColumnName("customLocation");
            entity.Property(e => e.CustomPricing)
                .HasDefaultValueSql("'0'")
                .HasColumnName("customPricing");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnName("deposit");
            entity.Property(e => e.DepositPayment)
                .HasDefaultValueSql("'disabled'")
                .HasColumnType("enum('disabled','fixed','percentage')")
                .HasColumnName("depositPayment");
            entity.Property(e => e.DepositPerPerson)
                .HasDefaultValueSql("'1'")
                .HasColumnName("depositPerPerson");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.FullPayment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fullPayment");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.MaxCapacity).HasColumnName("maxCapacity");
            entity.Property(e => e.MaxCustomCapacity).HasColumnName("maxCustomCapacity");
            entity.Property(e => e.MaxExtraPeople).HasColumnName("maxExtraPeople");
            entity.Property(e => e.MonthlyDate)
                .HasColumnType("datetime")
                .HasColumnName("monthlyDate");
            entity.Property(e => e.MonthlyOnDay)
                .HasColumnType("enum('monday','tuesday','wednesday','thursday','friday','saturday','sunday')")
                .HasColumnName("monthlyOnDay");
            entity.Property(e => e.MonthlyOnRepeat)
                .HasColumnType("enum('first','second','third','fourth','last')")
                .HasColumnName("monthlyOnRepeat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NotifyParticipants).HasColumnName("notifyParticipants");
            entity.Property(e => e.OrganizerId).HasColumnName("organizerId");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.RecurringCycle)
                .HasColumnType("enum('daily','weekly','monthly','yearly')")
                .HasColumnName("recurringCycle");
            entity.Property(e => e.RecurringInterval)
                .HasDefaultValueSql("'1'")
                .HasColumnName("recurringInterval");
            entity.Property(e => e.RecurringMonthly)
                .HasDefaultValueSql("'each'")
                .HasColumnType("enum('each','on')")
                .HasColumnName("recurringMonthly");
            entity.Property(e => e.RecurringOrder).HasColumnName("recurringOrder");
            entity.Property(e => e.RecurringUntil)
                .HasColumnType("datetime")
                .HasColumnName("recurringUntil");
            entity.Property(e => e.Settings)
                .HasColumnType("text")
                .HasColumnName("settings");
            entity.Property(e => e.Show)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show");
            entity.Property(e => e.Status)
                .HasColumnType("enum('approved','pending','canceled','rejected')")
                .HasColumnName("status");
            entity.Property(e => e.TicketRangeRec)
                .HasDefaultValueSql("'calculate'")
                .HasColumnType("enum('same','calculate')")
                .HasColumnName("ticketRangeRec");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
            entity.Property(e => e.ZoomUserId)
                .HasMaxLength(255)
                .HasColumnName("zoomUserId");
        });

        modelBuilder.Entity<IcaksAmeliaEventsPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_events_periods");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.GoogleCalendarEventId)
                .HasMaxLength(255)
                .HasColumnName("googleCalendarEventId");
            entity.Property(e => e.GoogleMeetUrl)
                .HasMaxLength(255)
                .HasColumnName("googleMeetUrl");
            entity.Property(e => e.LessonSpace)
                .HasColumnType("text")
                .HasColumnName("lessonSpace");
            entity.Property(e => e.OutlookCalendarEventId)
                .HasMaxLength(255)
                .HasColumnName("outlookCalendarEventId");
            entity.Property(e => e.PeriodEnd)
                .HasColumnType("datetime")
                .HasColumnName("periodEnd");
            entity.Property(e => e.PeriodStart)
                .HasColumnType("datetime")
                .HasColumnName("periodStart");
            entity.Property(e => e.ZoomMeeting)
                .HasColumnType("text")
                .HasColumnName("zoomMeeting");
        });

        modelBuilder.Entity<IcaksAmeliaEventsTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_events_tags");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IcaksAmeliaEventsToProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_events_to_providers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaEventsToTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_events_to_tickets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRanges)
                .HasColumnType("text")
                .HasColumnName("dateRanges");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("price");
            entity.Property(e => e.Spots).HasColumnName("spots");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_extras");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AggregatedPrice).HasColumnName("aggregatedPrice");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.MaxQuantity).HasColumnName("maxQuantity");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaGallery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_galleries");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntityId).HasColumnName("entityId");
            entity.Property(e => e.EntityType)
                .HasColumnType("enum('service','event','package')")
                .HasColumnName("entityType");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Position).HasColumnName("position");
        });

        modelBuilder.Entity<IcaksAmeliaLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_locations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Latitude)
                .HasPrecision(8, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(63)
                .HasColumnName("phone");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Pin)
                .HasColumnType("mediumtext")
                .HasColumnName("pin");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaLocationsView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_locations_views");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.Views).HasColumnName("views");
        });

        modelBuilder.Entity<IcaksAmeliaNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_notifications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CustomName)
                .HasMaxLength(255)
                .HasColumnName("customName");
            entity.Property(e => e.Entity)
                .HasDefaultValueSql("'appointment'")
                .HasColumnType("enum('appointment','event')")
                .HasColumnName("entity");
            entity.Property(e => e.MinimumTimeBeforeBooking)
                .HasColumnType("text")
                .HasColumnName("minimumTimeBeforeBooking");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.SendOnlyMe)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sendOnlyMe");
            entity.Property(e => e.SendTo)
                .HasColumnType("enum('customer','provider')")
                .HasColumnName("sendTo");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'enabled'")
                .HasColumnType("enum('enabled','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("subject");
            entity.Property(e => e.Time)
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.TimeAfter).HasColumnName("timeAfter");
            entity.Property(e => e.TimeBefore).HasColumnName("timeBefore");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
            entity.Property(e => e.Type)
                .HasColumnType("enum('email','sms','whatsapp')")
                .HasColumnName("type");
            entity.Property(e => e.WhatsAppTemplate)
                .HasMaxLength(255)
                .HasColumnName("whatsAppTemplate");
        });

        modelBuilder.Entity<IcaksAmeliaNotificationsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_notifications_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.NotificationId).HasColumnName("notificationId");
            entity.Property(e => e.PackageCustomerId).HasColumnName("packageCustomerId");
            entity.Property(e => e.Sent).HasColumnName("sent");
            entity.Property(e => e.SentDateTime)
                .HasColumnType("datetime")
                .HasColumnName("sentDateTime");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaNotificationsSmsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_notifications_sms_history");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlphaSenderId)
                .HasMaxLength(11)
                .HasColumnName("alphaSenderId");
            entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("dateTime");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.LogId).HasColumnName("logId");
            entity.Property(e => e.NotificationId).HasColumnName("notificationId");
            entity.Property(e => e.PackageCustomerId).HasColumnName("packageCustomerId");
            entity.Property(e => e.Phone)
                .HasMaxLength(63)
                .HasColumnName("phone");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Segments).HasColumnName("segments");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'prepared'")
                .HasColumnType("enum('prepared','accepted','queued','sent','failed','delivered','undelivered')")
                .HasColumnName("status");
            entity.Property(e => e.Text)
                .HasMaxLength(1600)
                .HasColumnName("text");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaNotificationsToEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_notifications_to_entities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Entity)
                .HasDefaultValueSql("'appointment'")
                .HasColumnType("enum('appointment','event')")
                .HasColumnName("entity");
            entity.Property(e => e.EntityId).HasColumnName("entityId");
            entity.Property(e => e.NotificationId).HasColumnName("notificationId");
        });

        modelBuilder.Entity<IcaksAmeliaPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalculatedPrice)
                .HasDefaultValueSql("'1'")
                .HasColumnName("calculatedPrice");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("color");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnName("deposit");
            entity.Property(e => e.DepositPayment)
                .HasDefaultValueSql("'disabled'")
                .HasColumnType("enum('disabled','fixed','percentage')")
                .HasColumnName("depositPayment");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.DurationCount).HasColumnName("durationCount");
            entity.Property(e => e.DurationType)
                .HasColumnType("enum('day','week','month')")
                .HasColumnName("durationType");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.FullPayment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fullPayment");
            entity.Property(e => e.LimitPerCustomer)
                .HasColumnType("text")
                .HasColumnName("limitPerCustomer");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasColumnName("position");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quantity");
            entity.Property(e => e.Settings)
                .HasColumnType("text")
                .HasColumnName("settings");
            entity.Property(e => e.SharedCapacity)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sharedCapacity");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaPackagesCustomersToService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages_customers_to_services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingsCount).HasColumnName("bookingsCount");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.PackageCustomerId).HasColumnName("packageCustomerId");
            entity.Property(e => e.ProviderId).HasColumnName("providerId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaPackagesServicesToLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages_services_to_locations");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.PackageServiceId).HasColumnName("packageServiceId");
        });

        modelBuilder.Entity<IcaksAmeliaPackagesServicesToProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages_services_to_providers");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PackageServiceId).HasColumnName("packageServiceId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaPackagesToCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages_to_customers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingsCount).HasColumnName("bookingsCount");
            entity.Property(e => e.CouponId).HasColumnName("couponId");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.End)
                .HasColumnType("datetime")
                .HasColumnName("end");
            entity.Property(e => e.PackageId).HasColumnName("packageId");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Purchased)
                .HasColumnType("datetime")
                .HasColumnName("purchased");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.Status)
                .HasColumnType("enum('approved','pending','canceled','rejected')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksAmeliaPackagesToService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_packages_to_services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowProviderSelection)
                .HasDefaultValueSql("'1'")
                .HasColumnName("allowProviderSelection");
            entity.Property(e => e.MaximumScheduled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maximumScheduled");
            entity.Property(e => e.MinimumScheduled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("minimumScheduled");
            entity.Property(e => e.PackageId).HasColumnName("packageId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_payments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionsCompleted).HasColumnName("actionsCompleted");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CustomerBookingId).HasColumnName("customerBookingId");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("dateTime");
            entity.Property(e => e.Entity)
                .HasColumnType("enum('appointment','event','package')")
                .HasColumnName("entity");
            entity.Property(e => e.Gateway)
                .HasColumnType("enum('onSite','payPal','stripe','wc','mollie','razorpay')")
                .HasColumnName("gateway");
            entity.Property(e => e.GatewayTitle)
                .HasMaxLength(255)
                .HasColumnName("gatewayTitle");
            entity.Property(e => e.PackageCustomerId).HasColumnName("packageCustomerId");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Status)
                .HasColumnType("enum('paid','pending','partiallyPaid','refunded')")
                .HasColumnName("status");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("transactionId");
            entity.Property(e => e.WcOrderId).HasColumnName("wcOrderId");
            entity.Property(e => e.WcOrderItemId).HasColumnName("wcOrderItemId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToDaysoff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_daysoff");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("endDate");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Repeat).HasColumnName("repeat");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToGoogleCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_google_calendar");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalendarId)
                .HasColumnType("text")
                .HasColumnName("calendarId");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_locations");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToOutlookCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_outlook_calendar");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalendarId)
                .HasColumnType("text")
                .HasColumnName("calendarId");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_periods");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("endTime");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("startTime");
            entity.Property(e => e.WeekDayId).HasColumnName("weekDayId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToPeriodsLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_periods_location");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.PeriodId).HasColumnName("periodId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToPeriodsService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_periods_services");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PeriodId).HasColumnName("periodId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_services");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomPricing)
                .HasColumnType("text")
                .HasColumnName("customPricing");
            entity.Property(e => e.MaxCapacity).HasColumnName("maxCapacity");
            entity.Property(e => e.MinCapacity).HasColumnName("minCapacity");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToSpecialday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_specialdays");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("endDate");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToSpecialdaysPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_specialdays_periods");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("endTime");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.SpecialDayId).HasColumnName("specialDayId");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("startTime");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToSpecialdaysPeriodsLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_specialdays_periods_location");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.PeriodId).HasColumnName("periodId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToSpecialdaysPeriodsService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_specialdays_periods_services");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PeriodId).HasColumnName("periodId");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToTimeout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_timeouts");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("endTime");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("startTime");
            entity.Property(e => e.WeekDayId).HasColumnName("weekDayId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersToWeekday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_to_weekdays");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayIndex).HasColumnName("dayIndex");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("endTime");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("startTime");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<IcaksAmeliaProvidersView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_providers_views");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Views).HasColumnName("views");
        });

        modelBuilder.Entity<IcaksAmeliaResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_resources");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountAdditionalPeople)
                .HasDefaultValueSql("'0'")
                .HasColumnName("countAdditionalPeople");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quantity");
            entity.Property(e => e.Shared)
                .HasColumnType("enum('service','location')")
                .HasColumnName("shared");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksAmeliaResourcesToEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_resources_to_entities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntityId).HasColumnName("entityId");
            entity.Property(e => e.EntityType)
                .HasDefaultValueSql("'service'")
                .HasColumnType("enum('service','location','employee')")
                .HasColumnName("entityType");
            entity.Property(e => e.ResourceId).HasColumnName("resourceId");
        });

        modelBuilder.Entity<IcaksAmeliaService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AggregatedPrice)
                .HasDefaultValueSql("'1'")
                .HasColumnName("aggregatedPrice");
            entity.Property(e => e.BringingAnyone)
                .HasDefaultValueSql("'1'")
                .HasColumnName("bringingAnyone");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("color");
            entity.Property(e => e.CustomPricing)
                .HasColumnType("text")
                .HasColumnName("customPricing");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnName("deposit");
            entity.Property(e => e.DepositPayment)
                .HasDefaultValueSql("'disabled'")
                .HasColumnType("enum('disabled','fixed','percentage')")
                .HasColumnName("depositPayment");
            entity.Property(e => e.DepositPerPerson)
                .HasDefaultValueSql("'1'")
                .HasColumnName("depositPerPerson");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FullPayment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fullPayment");
            entity.Property(e => e.LimitPerCustomer)
                .HasColumnType("text")
                .HasColumnName("limitPerCustomer");
            entity.Property(e => e.MandatoryExtra)
                .HasDefaultValueSql("'0'")
                .HasColumnName("mandatoryExtra");
            entity.Property(e => e.MaxCapacity).HasColumnName("maxCapacity");
            entity.Property(e => e.MaxExtraPeople).HasColumnName("maxExtraPeople");
            entity.Property(e => e.MinCapacity).HasColumnName("minCapacity");
            entity.Property(e => e.MinSelectedExtras)
                .HasDefaultValueSql("'0'")
                .HasColumnName("minSelectedExtras");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasColumnName("position");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Priority)
                .HasColumnType("enum('least_expensive','most_expensive','least_occupied','most_occupied')")
                .HasColumnName("priority");
            entity.Property(e => e.RecurringCycle)
                .HasDefaultValueSql("'disabled'")
                .HasColumnType("enum('disabled','all','daily','weekly','monthly')")
                .HasColumnName("recurringCycle");
            entity.Property(e => e.RecurringPayment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("recurringPayment");
            entity.Property(e => e.RecurringSub)
                .HasDefaultValueSql("'future'")
                .HasColumnType("enum('disabled','past','future','both')")
                .HasColumnName("recurringSub");
            entity.Property(e => e.Settings)
                .HasColumnType("text")
                .HasColumnName("settings");
            entity.Property(e => e.Show)
                .HasDefaultValueSql("'1'")
                .HasColumnName("show");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.TimeAfter)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timeAfter");
            entity.Property(e => e.TimeBefore)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timeBefore");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
        });

        modelBuilder.Entity<IcaksAmeliaServicesView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_services_views");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Views).HasColumnName("views");
        });

        modelBuilder.Entity<IcaksAmeliaUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_amelia_users");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeId).HasColumnName("badgeId");
            entity.Property(e => e.Birthday)
                .HasColumnType("date")
                .HasColumnName("birthday");
            entity.Property(e => e.CountryPhoneIso)
                .HasMaxLength(2)
                .HasColumnName("countryPhoneIso");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.ExternalId).HasColumnName("externalId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("lastName");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(63)
                .HasColumnName("phone");
            entity.Property(e => e.PictureFullPath)
                .HasMaxLength(767)
                .HasColumnName("pictureFullPath");
            entity.Property(e => e.PictureThumbPath)
                .HasMaxLength(767)
                .HasColumnName("pictureThumbPath");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('hidden','visible','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(255)
                .HasColumnName("timeZone");
            entity.Property(e => e.Translations)
                .HasColumnType("text")
                .HasColumnName("translations");
            entity.Property(e => e.Type)
                .HasColumnType("enum('customer','provider','manager','admin')")
                .HasColumnName("type");
            entity.Property(e => e.UsedTokens)
                .HasColumnType("text")
                .HasColumnName("usedTokens");
            entity.Property(e => e.ZoomUserId)
                .HasMaxLength(255)
                .HasColumnName("zoomUserId");
        });

        modelBuilder.Entity<IcaksAutomatorwpAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_actions");

            entity.HasIndex(e => e.AutomationId, "automation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutomationId).HasColumnName("automation_id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
        });

        modelBuilder.Entity<IcaksAutomatorwpActionsMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_actions_meta");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksAutomatorwpAutomation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_automations");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Sequential).HasColumnName("sequential");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Times).HasColumnName("times");
            entity.Property(e => e.TimesPerUser)
                .HasDefaultValueSql("'1'")
                .HasColumnName("times_per_user");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksAutomatorwpAutomationsMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_automations_meta");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksAutomatorwpLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_logs");

            entity.HasIndex(e => e.ObjectId, "object_id");

            entity.HasIndex(e => e.PostId, "post_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksAutomatorwpLogsMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_logs_meta");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksAutomatorwpTrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_triggers");

            entity.HasIndex(e => e.AutomationId, "automation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutomationId).HasColumnName("automation_id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
        });

        modelBuilder.Entity<IcaksAutomatorwpTriggersMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_automatorwp_triggers_meta");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksBwfAbExperiment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_ab_experiments");

            entity.HasIndex(e => e.Id, "id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.Control).HasColumnName("control");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateCompleted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_completed");
            entity.Property(e => e.DateStarted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_started");
            entity.Property(e => e.Desc)
                .HasColumnType("text")
                .HasColumnName("desc");
            entity.Property(e => e.Goal).HasColumnName("goal");
            entity.Property(e => e.LastResetDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("last_reset_date");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("enum('1','2','3','4')")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Variants).HasColumnName("variants");
        });

        modelBuilder.Entity<IcaksBwfAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_actions");

            entity.HasIndex(e => e.ClaimId, "claim_id");

            entity.HasIndex(e => e.ETime, "e_time");

            entity.HasIndex(e => e.GroupSlug, "group_slug");

            entity.HasIndex(e => e.Hook, "hook");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Args).HasColumnName("args");
            entity.Property(e => e.CDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("c_date");
            entity.Property(e => e.ClaimId).HasColumnName("claim_id");
            entity.Property(e => e.ETime).HasColumnName("e_time");
            entity.Property(e => e.GroupSlug)
                .HasDefaultValueSql("'woofunnels'")
                .HasColumnName("group_slug");
            entity.Property(e => e.Hook).HasColumnName("hook");
            entity.Property(e => e.RecurringInterval).HasColumnName("recurring_interval");
            entity.Property(e => e.Status)
                .HasComment("0 - Pending | 1 - Running")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksBwfActionClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_action_claim");

            entity.HasIndex(e => e.Date, "date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date");
        });

        modelBuilder.Entity<IcaksBwfContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_contact");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Uid, "uid");

            entity.HasIndex(e => e.Wpid, "wpid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .HasColumnName("contact_no");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FName)
                .HasMaxLength(100)
                .HasColumnName("f_name");
            entity.Property(e => e.LName)
                .HasMaxLength(100)
                .HasColumnName("l_name");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");
            entity.Property(e => e.Lists).HasColumnName("lists");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.Source)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("source");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Tags).HasColumnName("tags");
            entity.Property(e => e.Timezone)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("timezone");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("'lead'")
                .HasColumnName("type");
            entity.Property(e => e.Uid)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .HasColumnName("uid");
            entity.Property(e => e.Wpid).HasColumnName("wpid");
        });

        modelBuilder.Entity<IcaksBwfContactMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_contact_meta");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(50)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksBwfConversionTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_conversion_tracking");

            entity.HasIndex(e => e.FunnelId, "funnel_id");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.StepId, "step_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutomationId).HasColumnName("automation_id");
            entity.Property(e => e.Browser)
                .HasMaxLength(100)
                .HasColumnName("browser");
            entity.Property(e => e.ClickId)
                .HasMaxLength(255)
                .HasColumnName("click_id");
            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Device)
                .HasMaxLength(100)
                .HasColumnName("device");
            entity.Property(e => e.FirstClick)
                .HasColumnType("datetime")
                .HasColumnName("first_click");
            entity.Property(e => e.FunnelId).HasColumnName("funnel_id");
            entity.Property(e => e.Referrer).HasColumnName("referrer");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.StepId).HasColumnName("step_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasComment("1- optin 2- wc_order 3- edd_order")
                .HasColumnName("type");
            entity.Property(e => e.UtmCampaign).HasColumnName("utm_campaign");
            entity.Property(e => e.UtmContent).HasColumnName("utm_content");
            entity.Property(e => e.UtmMedium).HasColumnName("utm_medium");
            entity.Property(e => e.UtmSource).HasColumnName("utm_source");
            entity.Property(e => e.UtmTerm).HasColumnName("utm_term");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<IcaksBwfFunnel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_funnels");

            entity.HasIndex(e => e.Id, "id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Desc)
                .HasColumnType("text")
                .HasColumnName("desc");
            entity.Property(e => e.Steps).HasColumnName("steps");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
        });

        modelBuilder.Entity<IcaksBwfFunnelmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_funnelmeta");

            entity.HasIndex(e => e.BwfFunnelId, "bwf_funnel_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.BwfFunnelId).HasColumnName("bwf_funnel_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksBwfOptinEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_optin_entries");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.Id, "id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FunnelId).HasColumnName("funnel_id");
            entity.Property(e => e.Opid)
                .HasMaxLength(255)
                .HasColumnName("opid");
            entity.Property(e => e.StepId).HasColumnName("step_id");
        });

        modelBuilder.Entity<IcaksBwfOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_options");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Key, "key");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(150)
                .HasColumnName("key");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<IcaksBwfWcCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwf_wc_customers");

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.Id, "id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aov).HasColumnName("aov");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.FOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("f_order_date");
            entity.Property(e => e.LOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("l_order_date");
            entity.Property(e => e.PurchasedProducts).HasColumnName("purchased_products");
            entity.Property(e => e.PurchasedProductsCats).HasColumnName("purchased_products_cats");
            entity.Property(e => e.PurchasedProductsTags).HasColumnName("purchased_products_tags");
            entity.Property(e => e.TotalOrderCount).HasColumnName("total_order_count");
            entity.Property(e => e.TotalOrderValue).HasColumnName("total_order_value");
            entity.Property(e => e.UsedCoupons).HasColumnName("used_coupons");
        });

        modelBuilder.Entity<IcaksBwfanAbandonedcart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_abandonedcarts");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.LastModified, "last_modified");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => e.Token, "token");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CheckoutData).HasColumnName("checkout_data");
            entity.Property(e => e.CheckoutPageId).HasColumnName("checkout_page_id");
            entity.Property(e => e.CookieKey)
                .HasMaxLength(32)
                .HasColumnName("cookie_key");
            entity.Property(e => e.Coupons).HasColumnName("coupons");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("created_time");
            entity.Property(e => e.Currency)
                .HasMaxLength(8)
                .HasColumnName("currency");
            entity.Property(e => e.Email)
                .HasMaxLength(32)
                .HasColumnName("email");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.Items).HasColumnName("items");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ShippingTaxTotal)
                .HasMaxLength(32)
                .HasColumnName("shipping_tax_total");
            entity.Property(e => e.ShippingTotal)
                .HasMaxLength(32)
                .HasColumnName("shipping_total");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .HasColumnName("token");
            entity.Property(e => e.Total)
                .HasMaxLength(32)
                .HasColumnName("total");
            entity.Property(e => e.TotalBase)
                .HasMaxLength(32)
                .HasColumnName("total_base");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksBwfanAutomation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automations");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Benchmark).HasColumnName("benchmark");
            entity.Property(e => e.Event)
                .HasMaxLength(60)
                .HasColumnName("event");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Source)
                .HasMaxLength(60)
                .HasColumnName("source");
            entity.Property(e => e.Start).HasColumnName("start");
            entity.Property(e => e.Status)
                .HasComment("1 - Active 2 - Inactive")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.V)
                .HasDefaultValueSql("'1'")
                .HasColumnName("v");
        });

        modelBuilder.Entity<IcaksBwfanAutomationCompleteContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automation_complete_contact");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Aid, "aid");

            entity.HasIndex(e => e.CDate, "c_date");

            entity.HasIndex(e => e.Cid, "cid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aid).HasColumnName("aid");
            entity.Property(e => e.CDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Completion Date")
                .HasColumnType("datetime")
                .HasColumnName("c_date");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Event)
                .HasMaxLength(120)
                .HasColumnName("event");
            entity.Property(e => e.SDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Start Date")
                .HasColumnType("datetime")
                .HasColumnName("s_date");
            entity.Property(e => e.Trail)
                .HasMaxLength(40)
                .HasComment("Trail ID")
                .HasColumnName("trail");
        });

        modelBuilder.Entity<IcaksBwfanAutomationContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automation_contact");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Aid, "aid");

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.ClaimId, "claim_id");

            entity.HasIndex(e => e.ETime, "e_time");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aid).HasColumnName("aid");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.CDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Start Date")
                .HasColumnType("datetime")
                .HasColumnName("c_date");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.ClaimId).HasColumnName("claim_id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.ETime).HasColumnName("e_time");
            entity.Property(e => e.Event)
                .HasMaxLength(120)
                .HasColumnName("event");
            entity.Property(e => e.Last).HasColumnName("last");
            entity.Property(e => e.LastTime).HasColumnName("last_time");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Active | 2 - Failed | 3 - Paused | 4 - Waiting | 5 - Terminate | 6 - Retry")
                .HasColumnName("status");
            entity.Property(e => e.Trail)
                .HasMaxLength(40)
                .HasComment("Trail ID")
                .HasColumnName("trail");
        });

        modelBuilder.Entity<IcaksBwfanAutomationContactClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automation_contact_claim");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
        });

        modelBuilder.Entity<IcaksBwfanAutomationContactTrail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automation_contact_trail");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.Sid, "sid");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => e.Tid, "tid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aid)
                .HasComment("Automation ID")
                .HasColumnName("aid");
            entity.Property(e => e.CTime).HasColumnName("c_time");
            entity.Property(e => e.Cid)
                .HasComment("Contact ID")
                .HasColumnName("cid");
            entity.Property(e => e.Data)
                .HasMaxLength(255)
                .HasColumnName("data");
            entity.Property(e => e.Sid)
                .HasComment("Step ID")
                .HasColumnName("sid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Success | 2 - Wait | 3 - Failed | 4 - Skipped")
                .HasColumnName("status");
            entity.Property(e => e.Tid)
                .HasMaxLength(40)
                .HasComment("Trail ID")
                .HasColumnName("tid");
        });

        modelBuilder.Entity<IcaksBwfanAutomationStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automation_step");

            entity.HasIndex(e => e.Aid, "aid");

            entity.HasIndex(e => e.Type, "type");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Aid).HasColumnName("aid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Status)
                .HasComment("1 - Active | 2 - Draft | 3 - Deleted")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Wait | 2 - Action | 3 - Goal | 4 - Conditional | 5 - Exit")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<IcaksBwfanAutomationmetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_automationmeta");

            entity.HasIndex(e => e.BwfanAutomationId, "bwfan_automation_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BwfanAutomationId).HasColumnName("bwfan_automation_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksBwfanMessageUnsubscribe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_bwfan_message_unsubscribe");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.AutomationId, "automation_id");

            entity.HasIndex(e => e.CDate, "c_date");

            entity.HasIndex(e => e.CType, "c_type");

            entity.HasIndex(e => e.Mode, "mode");

            entity.HasIndex(e => e.Recipient, "recipient");

            entity.HasIndex(e => e.Sid, "sid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AutomationId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("automation_id");
            entity.Property(e => e.CDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("c_date");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Automation 2 - Broadcast 3 - Manual 4 - Form")
                .HasColumnName("c_type");
            entity.Property(e => e.Mode)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Email 2 - SMS")
                .HasColumnName("mode");
            entity.Property(e => e.Recipient).HasColumnName("recipient");
            entity.Property(e => e.Sid)
                .HasComment("Step ID")
                .HasColumnName("sid");
        });

        modelBuilder.Entity<IcaksCartbounty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_cartbounty");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CartContents).HasColumnName("cart_contents");
            entity.Property(e => e.CartTotal)
                .HasPrecision(10)
                .HasColumnName("cart_total");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.MailSent).HasColumnName("mail_sent");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.OtherFields).HasColumnName("other_fields");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.SavedVia)
                .HasMaxLength(10)
                .HasColumnName("saved_via");
            entity.Property(e => e.SessionId)
                .HasMaxLength(60)
                .HasColumnName("session_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(60)
                .HasColumnName("surname");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("type");
            entity.Property(e => e.WpComplete)
                .HasDefaultValueSql("'0'")
                .HasColumnName("wp_complete");
            entity.Property(e => e.WpStepsCompleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("wp_steps_completed");
            entity.Property(e => e.WpUnsubscribed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("wp_unsubscribed");
        });

        modelBuilder.Entity<IcaksComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("icaks_comments");

            entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "comment_approved_date_gmt");

            entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email");

            entity.HasIndex(e => e.CommentDateGmt, "comment_date_gmt");

            entity.HasIndex(e => e.CommentParent, "comment_parent");

            entity.HasIndex(e => e.CommentPostId, "comment_post_ID");

            entity.HasIndex(e => e.CommentType, "woo_idx_comment_type");

            entity.Property(e => e.CommentId).HasColumnName("comment_ID");
            entity.Property(e => e.CommentAgent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment_agent");
            entity.Property(e => e.CommentApproved)
                .HasMaxLength(20)
                .HasDefaultValueSql("'1'")
                .HasColumnName("comment_approved");
            entity.Property(e => e.CommentAuthor)
                .HasColumnType("tinytext")
                .HasColumnName("comment_author");
            entity.Property(e => e.CommentAuthorEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("comment_author_email");
            entity.Property(e => e.CommentAuthorIp)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("comment_author_IP");
            entity.Property(e => e.CommentAuthorUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("comment_author_url");
            entity.Property(e => e.CommentContent)
                .HasColumnType("text")
                .HasColumnName("comment_content");
            entity.Property(e => e.CommentDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("comment_date");
            entity.Property(e => e.CommentDateGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("comment_date_gmt");
            entity.Property(e => e.CommentKarma).HasColumnName("comment_karma");
            entity.Property(e => e.CommentParent).HasColumnName("comment_parent");
            entity.Property(e => e.CommentPostId).HasColumnName("comment_post_ID");
            entity.Property(e => e.CommentType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'comment'")
                .HasColumnName("comment_type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksCommentmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_commentmeta");

            entity.HasIndex(e => e.CommentId, "comment_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.CommentId).HasColumnName("comment_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksEEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_e_events");

            entity.HasIndex(e => e.CreatedAt, "created_at_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EventData)
                .HasColumnType("text")
                .HasColumnName("event_data");
        });

        modelBuilder.Entity<IcaksFkCartStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_fk_cart_stats");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.Oid, "oid");

            entity.HasIndex(e => e.Pid, "pid");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cid)
                .HasComment("Contact ID")
                .HasColumnName("cid");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateCreatedGmt)
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.Oid)
                .HasComment("Order ID")
                .HasColumnName("oid");
            entity.Property(e => e.Pid)
                .HasComment("Product ID")
                .HasColumnName("pid");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IcaksLink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PRIMARY");

            entity.ToTable("icaks_links");

            entity.HasIndex(e => e.LinkVisible, "link_visible");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.LinkDescription)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_description");
            entity.Property(e => e.LinkImage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_image");
            entity.Property(e => e.LinkName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_name");
            entity.Property(e => e.LinkNotes)
                .HasColumnType("mediumtext")
                .HasColumnName("link_notes");
            entity.Property(e => e.LinkOwner)
                .HasDefaultValueSql("'1'")
                .HasColumnName("link_owner");
            entity.Property(e => e.LinkRating).HasColumnName("link_rating");
            entity.Property(e => e.LinkRel)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_rel");
            entity.Property(e => e.LinkRss)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_rss");
            entity.Property(e => e.LinkTarget)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("link_target");
            entity.Property(e => e.LinkUpdated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("link_updated");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("link_url");
            entity.Property(e => e.LinkVisible)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("link_visible");
        });

        modelBuilder.Entity<IcaksOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity.ToTable("icaks_options");

            entity.HasIndex(e => e.Autoload, "autoload");

            entity.HasIndex(e => e.OptionName, "option_name").IsUnique();

            entity.Property(e => e.OptionId).HasColumnName("option_id");
            entity.Property(e => e.Autoload)
                .HasMaxLength(20)
                .HasDefaultValueSql("'yes'")
                .HasColumnName("autoload");
            entity.Property(e => e.OptionName)
                .HasMaxLength(191)
                .HasDefaultValueSql("''")
                .HasColumnName("option_name");
            entity.Property(e => e.OptionValue).HasColumnName("option_value");
        });

        modelBuilder.Entity<IcaksPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_posts");

            entity.HasIndex(e => e.PostAuthor, "post_author");

            entity.HasIndex(e => e.PostName, "post_name");

            entity.HasIndex(e => e.PostParent, "post_parent");

            entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "type_status_date");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommentCount).HasColumnName("comment_count");
            entity.Property(e => e.CommentStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'open'")
                .HasColumnName("comment_status");
            entity.Property(e => e.Guid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("guid");
            entity.Property(e => e.MenuOrder).HasColumnName("menu_order");
            entity.Property(e => e.PingStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'open'")
                .HasColumnName("ping_status");
            entity.Property(e => e.Pinged)
                .HasColumnType("text")
                .HasColumnName("pinged");
            entity.Property(e => e.PostAuthor).HasColumnName("post_author");
            entity.Property(e => e.PostContent).HasColumnName("post_content");
            entity.Property(e => e.PostContentFiltered).HasColumnName("post_content_filtered");
            entity.Property(e => e.PostDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("post_date");
            entity.Property(e => e.PostDateGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("post_date_gmt");
            entity.Property(e => e.PostExcerpt)
                .HasColumnType("text")
                .HasColumnName("post_excerpt");
            entity.Property(e => e.PostMimeType)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("post_mime_type");
            entity.Property(e => e.PostModified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("post_modified");
            entity.Property(e => e.PostModifiedGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("post_modified_gmt");
            entity.Property(e => e.PostName)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("post_name");
            entity.Property(e => e.PostParent).HasColumnName("post_parent");
            entity.Property(e => e.PostPassword)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("post_password");
            entity.Property(e => e.PostStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'publish'")
                .HasColumnName("post_status");
            entity.Property(e => e.PostTitle)
                .HasColumnType("text")
                .HasColumnName("post_title");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'post'")
                .HasColumnName("post_type");
            entity.Property(e => e.ToPing)
                .HasColumnType("text")
                .HasColumnName("to_ping");
        });

        modelBuilder.Entity<IcaksPostmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_postmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.PostId, "post_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.PostId).HasColumnName("post_id");
        });

        modelBuilder.Entity<IcaksTecEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("icaks_tec_events");

            entity.HasIndex(e => e.PostId, "post_id").IsUnique();

            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'7200'")
                .HasColumnType("mediumint")
                .HasColumnName("duration");
            entity.Property(e => e.EndDate)
                .HasMaxLength(19)
                .HasColumnName("end_date");
            entity.Property(e => e.EndDateUtc)
                .HasMaxLength(19)
                .HasColumnName("end_date_utc");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasColumnName("hash");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(19)
                .HasColumnName("start_date");
            entity.Property(e => e.StartDateUtc)
                .HasMaxLength(19)
                .HasColumnName("start_date_utc");
            entity.Property(e => e.Timezone)
                .HasMaxLength(30)
                .HasDefaultValueSql("'UTC'")
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<IcaksTecOccurrence>(entity =>
        {
            entity.HasKey(e => e.OccurrenceId).HasName("PRIMARY");

            entity.ToTable("icaks_tec_occurrences");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.Hash, "hash").IsUnique();

            entity.Property(e => e.OccurrenceId).HasColumnName("occurrence_id");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'7200'")
                .HasColumnType("mediumint")
                .HasColumnName("duration");
            entity.Property(e => e.EndDate)
                .HasMaxLength(19)
                .HasColumnName("end_date");
            entity.Property(e => e.EndDateUtc)
                .HasMaxLength(19)
                .HasColumnName("end_date_utc");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasColumnName("hash");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(19)
                .HasColumnName("start_date");
            entity.Property(e => e.StartDateUtc)
                .HasMaxLength(19)
                .HasColumnName("start_date_utc");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<IcaksTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("PRIMARY");

            entity.ToTable("icaks_terms");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.Slug, "slug");

            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("slug");
            entity.Property(e => e.TermGroup).HasColumnName("term_group");
        });

        modelBuilder.Entity<IcaksTermRelationship>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId }).HasName("PRIMARY");

            entity.ToTable("icaks_term_relationships");

            entity.HasIndex(e => e.TermTaxonomyId, "term_taxonomy_id");

            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.TermTaxonomyId).HasColumnName("term_taxonomy_id");
            entity.Property(e => e.TermOrder).HasColumnName("term_order");
        });

        modelBuilder.Entity<IcaksTermTaxonomy>(entity =>
        {
            entity.HasKey(e => e.TermTaxonomyId).HasName("PRIMARY");

            entity.ToTable("icaks_term_taxonomy");

            entity.HasIndex(e => e.Taxonomy, "taxonomy");

            entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "term_id_taxonomy").IsUnique();

            entity.Property(e => e.TermTaxonomyId).HasColumnName("term_taxonomy_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("taxonomy");
            entity.Property(e => e.TermId).HasColumnName("term_id");
        });

        modelBuilder.Entity<IcaksTermmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_termmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.TermId, "term_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.TermId).HasColumnName("term_id");
        });

        modelBuilder.Entity<IcaksTutorEarning>(entity =>
        {
            entity.HasKey(e => e.EarningId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_earnings");

            entity.Property(e => e.EarningId).HasColumnName("earning_id");
            entity.Property(e => e.AdminAmount)
                .HasPrecision(16)
                .HasColumnName("admin_amount");
            entity.Property(e => e.AdminRate)
                .HasPrecision(16)
                .HasColumnName("admin_rate");
            entity.Property(e => e.CommissionType)
                .HasMaxLength(20)
                .HasColumnName("commission_type");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CoursePriceGrandTotal)
                .HasPrecision(16)
                .HasColumnName("course_price_grand_total");
            entity.Property(e => e.CoursePriceTotal)
                .HasPrecision(16)
                .HasColumnName("course_price_total");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DeductFeesAmount)
                .HasPrecision(16)
                .HasColumnName("deduct_fees_amount");
            entity.Property(e => e.DeductFeesName)
                .HasMaxLength(250)
                .HasColumnName("deduct_fees_name");
            entity.Property(e => e.DeductFeesType)
                .HasMaxLength(20)
                .HasColumnName("deduct_fees_type");
            entity.Property(e => e.InstructorAmount)
                .HasPrecision(16)
                .HasColumnName("instructor_amount");
            entity.Property(e => e.InstructorRate)
                .HasPrecision(16)
                .HasColumnName("instructor_rate");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .HasColumnName("order_status");
            entity.Property(e => e.ProcessBy)
                .HasMaxLength(20)
                .HasColumnName("process_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksTutorQuizAttempt>(entity =>
        {
            entity.HasKey(e => e.AttemptId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_quiz_attempts");

            entity.Property(e => e.AttemptId).HasColumnName("attempt_id");
            entity.Property(e => e.AttemptEndedAt)
                .HasColumnType("datetime")
                .HasColumnName("attempt_ended_at");
            entity.Property(e => e.AttemptInfo)
                .HasColumnType("text")
                .HasColumnName("attempt_info");
            entity.Property(e => e.AttemptIp)
                .HasMaxLength(250)
                .HasColumnName("attempt_ip");
            entity.Property(e => e.AttemptStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("attempt_started_at");
            entity.Property(e => e.AttemptStatus)
                .HasMaxLength(50)
                .HasColumnName("attempt_status");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.EarnedMarks)
                .HasPrecision(9)
                .HasColumnName("earned_marks");
            entity.Property(e => e.IsManuallyReviewed).HasColumnName("is_manually_reviewed");
            entity.Property(e => e.ManuallyReviewedAt)
                .HasColumnType("datetime")
                .HasColumnName("manually_reviewed_at");
            entity.Property(e => e.QuizId).HasColumnName("quiz_id");
            entity.Property(e => e.TotalAnsweredQuestions).HasColumnName("total_answered_questions");
            entity.Property(e => e.TotalMarks)
                .HasPrecision(9)
                .HasColumnName("total_marks");
            entity.Property(e => e.TotalQuestions).HasColumnName("total_questions");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksTutorQuizAttemptAnswer>(entity =>
        {
            entity.HasKey(e => e.AttemptAnswerId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_quiz_attempt_answers");

            entity.Property(e => e.AttemptAnswerId).HasColumnName("attempt_answer_id");
            entity.Property(e => e.AchievedMark)
                .HasPrecision(8)
                .HasColumnName("achieved_mark");
            entity.Property(e => e.GivenAnswer).HasColumnName("given_answer");
            entity.Property(e => e.IsCorrect).HasColumnName("is_correct");
            entity.Property(e => e.MinusMark)
                .HasPrecision(8)
                .HasColumnName("minus_mark");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.QuestionMark)
                .HasPrecision(8)
                .HasColumnName("question_mark");
            entity.Property(e => e.QuizAttemptId).HasColumnName("quiz_attempt_id");
            entity.Property(e => e.QuizId).HasColumnName("quiz_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksTutorQuizQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_quiz_questions");

            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.AnswerExplanation).HasColumnName("answer_explanation");
            entity.Property(e => e.QuestionDescription).HasColumnName("question_description");
            entity.Property(e => e.QuestionMark)
                .HasPrecision(9)
                .HasColumnName("question_mark");
            entity.Property(e => e.QuestionOrder).HasColumnName("question_order");
            entity.Property(e => e.QuestionSettings).HasColumnName("question_settings");
            entity.Property(e => e.QuestionTitle)
                .HasColumnType("text")
                .HasColumnName("question_title");
            entity.Property(e => e.QuestionType)
                .HasMaxLength(50)
                .HasColumnName("question_type");
            entity.Property(e => e.QuizId).HasColumnName("quiz_id");
        });

        modelBuilder.Entity<IcaksTutorQuizQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.AnswerId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_quiz_question_answers");

            entity.Property(e => e.AnswerId).HasColumnName("answer_id");
            entity.Property(e => e.AnswerOrder)
                .HasDefaultValueSql("'0'")
                .HasColumnName("answer_order");
            entity.Property(e => e.AnswerSettings)
                .HasColumnType("text")
                .HasColumnName("answer_settings");
            entity.Property(e => e.AnswerTitle)
                .HasColumnType("text")
                .HasColumnName("answer_title");
            entity.Property(e => e.AnswerTwoGapMatch)
                .HasColumnType("text")
                .HasColumnName("answer_two_gap_match");
            entity.Property(e => e.AnswerViewFormat)
                .HasMaxLength(250)
                .HasColumnName("answer_view_format");
            entity.Property(e => e.BelongsQuestionId).HasColumnName("belongs_question_id");
            entity.Property(e => e.BelongsQuestionType)
                .HasMaxLength(250)
                .HasColumnName("belongs_question_type");
            entity.Property(e => e.ImageId).HasColumnName("image_id");
            entity.Property(e => e.IsCorrect).HasColumnName("is_correct");
        });

        modelBuilder.Entity<IcaksTutorWithdraw>(entity =>
        {
            entity.HasKey(e => e.WithdrawId).HasName("PRIMARY");

            entity.ToTable("icaks_tutor_withdraws");

            entity.Property(e => e.WithdrawId).HasColumnName("withdraw_id");
            entity.Property(e => e.Amount)
                .HasPrecision(16)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.MethodData)
                .HasColumnType("text")
                .HasColumnName("method_data");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_users");

            entity.HasIndex(e => e.UserEmail, "user_email");

            entity.HasIndex(e => e.UserLogin, "user_login_key");

            entity.HasIndex(e => e.UserNicename, "user_nicename");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("display_name");
            entity.Property(e => e.UserActivationKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("user_activation_key");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(60)
                .HasDefaultValueSql("''")
                .HasColumnName("user_login");
            entity.Property(e => e.UserNicename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("user_nicename");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("user_pass");
            entity.Property(e => e.UserRegistered)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("user_registered");
            entity.Property(e => e.UserStatus).HasColumnName("user_status");
            entity.Property(e => e.UserUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("user_url");
        });

        modelBuilder.Entity<IcaksUsermetum>(entity =>
        {
            entity.HasKey(e => e.UmetaId).HasName("PRIMARY");

            entity.ToTable("icaks_usermeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.UmetaId).HasColumnName("umeta_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksWcAdminNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_admin_notes");

            entity.Property(e => e.NoteId).HasColumnName("note_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.ContentData).HasColumnName("content_data");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateReminder)
                .HasColumnType("datetime")
                .HasColumnName("date_reminder");
            entity.Property(e => e.Icon)
                .HasMaxLength(200)
                .HasDefaultValueSql("'info'")
                .HasColumnName("icon");
            entity.Property(e => e.Image)
                .HasMaxLength(200)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.IsSnoozable).HasColumnName("is_snoozable");
            entity.Property(e => e.Layout)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("layout");
            entity.Property(e => e.Locale)
                .HasMaxLength(20)
                .HasColumnName("locale");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<IcaksWcAdminNoteAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_admin_note_actions");

            entity.HasIndex(e => e.NoteId, "note_id");

            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.ActionedText)
                .HasMaxLength(255)
                .HasColumnName("actioned_text");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasColumnName("label");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NonceAction)
                .HasMaxLength(255)
                .HasColumnName("nonce_action");
            entity.Property(e => e.NonceName)
                .HasMaxLength(255)
                .HasColumnName("nonce_name");
            entity.Property(e => e.NoteId).HasColumnName("note_id");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksWcCategoryLookup>(entity =>
        {
            entity.HasKey(e => new { e.CategoryTreeId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("icaks_wc_category_lookup");

            entity.Property(e => e.CategoryTreeId).HasColumnName("category_tree_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
        });

        modelBuilder.Entity<IcaksWcCustomerLookup>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_customer_lookup");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.DateLastActive)
                .HasColumnType("timestamp")
                .HasColumnName("date_last_active");
            entity.Property(e => e.DateRegistered)
                .HasColumnType("timestamp")
                .HasColumnName("date_registered");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("state");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(60)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<IcaksWcDownloadLog>(entity =>
        {
            entity.HasKey(e => e.DownloadLogId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_download_log");

            entity.HasIndex(e => e.PermissionId, "permission_id");

            entity.HasIndex(e => e.Timestamp, "timestamp");

            entity.Property(e => e.DownloadLogId).HasColumnName("download_log_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserIpAddress)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("user_ip_address");
        });

        modelBuilder.Entity<IcaksWcOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wc_orders");

            entity.HasIndex(e => e.BillingEmail, "billing_email");

            entity.HasIndex(e => new { e.CustomerId, e.BillingEmail }, "customer_id_billing_email");

            entity.HasIndex(e => e.DateCreatedGmt, "date_created");

            entity.HasIndex(e => e.DateUpdatedGmt, "date_updated");

            entity.HasIndex(e => e.ParentOrderId, "parent_order_id");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => new { e.Type, e.Status, e.DateCreatedGmt }, "type_status_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(320)
                .HasColumnName("billing_email");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerNote)
                .HasColumnType("text")
                .HasColumnName("customer_note");
            entity.Property(e => e.DateCreatedGmt)
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DateUpdatedGmt)
                .HasColumnType("datetime")
                .HasColumnName("date_updated_gmt");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasColumnName("ip_address");
            entity.Property(e => e.ParentOrderId).HasColumnName("parent_order_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .HasColumnName("payment_method");
            entity.Property(e => e.PaymentMethodTitle)
                .HasColumnType("text")
                .HasColumnName("payment_method_title");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasPrecision(26, 8)
                .HasColumnName("tax_amount");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(26, 8)
                .HasColumnName("total_amount");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .HasColumnName("transaction_id");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
            entity.Property(e => e.UserAgent)
                .HasColumnType("text")
                .HasColumnName("user_agent");
        });

        modelBuilder.Entity<IcaksWcOrderAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_addresses");

            entity.HasIndex(e => new { e.AddressType, e.OrderId }, "address_type_order_id").IsUnique();

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.Phone, "phone");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("text")
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasColumnType("text")
                .HasColumnName("address_2");
            entity.Property(e => e.AddressType)
                .HasMaxLength(20)
                .HasColumnName("address_type");
            entity.Property(e => e.City)
                .HasColumnType("text")
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasColumnType("text")
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasColumnType("text")
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("text")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("text")
                .HasColumnName("last_name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasColumnType("text")
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasColumnType("text")
                .HasColumnName("state");
        });

        modelBuilder.Entity<IcaksWcOrderCouponLookup>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.CouponId }).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_coupon_lookup");

            entity.HasIndex(e => e.CouponId, "coupon_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");
        });

        modelBuilder.Entity<IcaksWcOrderOperationalDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_operational_data");

            entity.HasIndex(e => e.OrderId, "order_id").IsUnique();

            entity.HasIndex(e => e.OrderKey, "order_key");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CartHash)
                .HasMaxLength(100)
                .HasColumnName("cart_hash");
            entity.Property(e => e.CouponUsagesAreCounted).HasColumnName("coupon_usages_are_counted");
            entity.Property(e => e.CreatedVia)
                .HasMaxLength(100)
                .HasColumnName("created_via");
            entity.Property(e => e.DateCompletedGmt)
                .HasColumnType("datetime")
                .HasColumnName("date_completed_gmt");
            entity.Property(e => e.DatePaidGmt)
                .HasColumnType("datetime")
                .HasColumnName("date_paid_gmt");
            entity.Property(e => e.DiscountTaxAmount)
                .HasPrecision(26, 8)
                .HasColumnName("discount_tax_amount");
            entity.Property(e => e.DiscountTotalAmount)
                .HasPrecision(26, 8)
                .HasColumnName("discount_total_amount");
            entity.Property(e => e.DownloadPermissionGranted).HasColumnName("download_permission_granted");
            entity.Property(e => e.NewOrderEmailSent).HasColumnName("new_order_email_sent");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderKey)
                .HasMaxLength(100)
                .HasColumnName("order_key");
            entity.Property(e => e.OrderStockReduced).HasColumnName("order_stock_reduced");
            entity.Property(e => e.PricesIncludeTax).HasColumnName("prices_include_tax");
            entity.Property(e => e.RecordedSales).HasColumnName("recorded_sales");
            entity.Property(e => e.ShippingTaxAmount)
                .HasPrecision(26, 8)
                .HasColumnName("shipping_tax_amount");
            entity.Property(e => e.ShippingTotalAmount)
                .HasPrecision(26, 8)
                .HasColumnName("shipping_total_amount");
            entity.Property(e => e.WoocommerceVersion)
                .HasMaxLength(20)
                .HasColumnName("woocommerce_version");
        });

        modelBuilder.Entity<IcaksWcOrderProductLookup>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_product_lookup");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
            entity.Property(e => e.CouponAmount).HasColumnName("coupon_amount");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductGrossRevenue).HasColumnName("product_gross_revenue");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductNetRevenue).HasColumnName("product_net_revenue");
            entity.Property(e => e.ProductQty).HasColumnName("product_qty");
            entity.Property(e => e.ShippingAmount).HasColumnName("shipping_amount");
            entity.Property(e => e.ShippingTaxAmount).HasColumnName("shipping_tax_amount");
            entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");
            entity.Property(e => e.VariationId).HasColumnName("variation_id");
        });

        modelBuilder.Entity<IcaksWcOrderStat>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_stats");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DateCompleted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_completed");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DatePaid)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_paid");
            entity.Property(e => e.NetTotal).HasColumnName("net_total");
            entity.Property(e => e.NumItemsSold).HasColumnName("num_items_sold");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ReturningCustomer).HasColumnName("returning_customer");
            entity.Property(e => e.ShippingTotal).HasColumnName("shipping_total");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TaxTotal).HasColumnName("tax_total");
            entity.Property(e => e.TotalSales).HasColumnName("total_sales");
        });

        modelBuilder.Entity<IcaksWcOrderTaxLookup>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.TaxRateId }).HasName("PRIMARY");

            entity.ToTable("icaks_wc_order_tax_lookup");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.OrderTax).HasColumnName("order_tax");
            entity.Property(e => e.ShippingTax).HasColumnName("shipping_tax");
            entity.Property(e => e.TotalTax).HasColumnName("total_tax");
        });

        modelBuilder.Entity<IcaksWcOrdersMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wc_orders_meta");

            entity.HasIndex(e => new { e.MetaKey, e.MetaValue }, "meta_key_value");

            entity.HasIndex(e => new { e.OrderId, e.MetaKey, e.MetaValue }, "order_id_meta_key_meta_value");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasColumnType("text")
                .HasColumnName("meta_value");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
        });

        modelBuilder.Entity<IcaksWcProductAttributesLookup>(entity =>
        {
            entity.HasKey(e => new { e.ProductOrParentId, e.TermId, e.ProductId, e.Taxonomy }).HasName("PRIMARY");

            entity.ToTable("icaks_wc_product_attributes_lookup");

            entity.HasIndex(e => new { e.IsVariationAttribute, e.TermId }, "is_variation_attribute_term_id");

            entity.Property(e => e.ProductOrParentId).HasColumnName("product_or_parent_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasColumnName("taxonomy");
            entity.Property(e => e.InStock).HasColumnName("in_stock");
            entity.Property(e => e.IsVariationAttribute).HasColumnName("is_variation_attribute");
        });

        modelBuilder.Entity<IcaksWcProductDownloadDirectory>(entity =>
        {
            entity.HasKey(e => e.UrlId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_product_download_directories");

            entity.HasIndex(e => e.Url, "url");

            entity.Property(e => e.UrlId).HasColumnName("url_id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Url)
                .HasMaxLength(256)
                .HasColumnName("url");
        });

        modelBuilder.Entity<IcaksWcProductMetaLookup>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_product_meta_lookup");

            entity.HasIndex(e => e.Downloadable, "downloadable");

            entity.HasIndex(e => new { e.MinPrice, e.MaxPrice }, "min_max_price");

            entity.HasIndex(e => e.Onsale, "onsale");

            entity.HasIndex(e => e.StockQuantity, "stock_quantity");

            entity.HasIndex(e => e.StockStatus, "stock_status");

            entity.HasIndex(e => e.Virtual, "virtual");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.AverageRating)
                .HasPrecision(3)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("average_rating");
            entity.Property(e => e.Downloadable)
                .HasDefaultValueSql("'0'")
                .HasColumnName("downloadable");
            entity.Property(e => e.MaxPrice)
                .HasPrecision(19, 4)
                .HasColumnName("max_price");
            entity.Property(e => e.MinPrice)
                .HasPrecision(19, 4)
                .HasColumnName("min_price");
            entity.Property(e => e.Onsale)
                .HasDefaultValueSql("'0'")
                .HasColumnName("onsale");
            entity.Property(e => e.RatingCount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("rating_count");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("sku");
            entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            entity.Property(e => e.StockStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'instock'")
                .HasColumnName("stock_status");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_class");
            entity.Property(e => e.TaxStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'taxable'")
                .HasColumnName("tax_status");
            entity.Property(e => e.TotalSales)
                .HasDefaultValueSql("'0'")
                .HasColumnName("total_sales");
            entity.Property(e => e.Virtual)
                .HasDefaultValueSql("'0'")
                .HasColumnName("virtual");
        });

        modelBuilder.Entity<IcaksWcRateLimit>(entity =>
        {
            entity.HasKey(e => e.RateLimitId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_rate_limits");

            entity.HasIndex(e => e.RateLimitKey, "rate_limit_key").IsUnique();

            entity.Property(e => e.RateLimitId).HasColumnName("rate_limit_id");
            entity.Property(e => e.RateLimitExpiry).HasColumnName("rate_limit_expiry");
            entity.Property(e => e.RateLimitKey)
                .HasMaxLength(200)
                .HasColumnName("rate_limit_key");
            entity.Property(e => e.RateLimitRemaining).HasColumnName("rate_limit_remaining");
        });

        modelBuilder.Entity<IcaksWcReservedStock>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("icaks_wc_reserved_stock");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Expires)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("expires");
            entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<IcaksWcTaxRateClass>(entity =>
        {
            entity.HasKey(e => e.TaxRateClassId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_tax_rate_classes");

            entity.HasIndex(e => e.Slug, "slug").IsUnique();

            entity.Property(e => e.TaxRateClassId).HasColumnName("tax_rate_class_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("slug");
        });

        modelBuilder.Entity<IcaksWcWebhook>(entity =>
        {
            entity.HasKey(e => e.WebhookId).HasName("PRIMARY");

            entity.ToTable("icaks_wc_webhooks");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.WebhookId).HasColumnName("webhook_id");
            entity.Property(e => e.ApiVersion).HasColumnName("api_version");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.DateModifiedGmt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_modified_gmt");
            entity.Property(e => e.DeliveryUrl)
                .HasColumnType("text")
                .HasColumnName("delivery_url");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.PendingDelivery).HasColumnName("pending_delivery");
            entity.Property(e => e.Secret)
                .HasColumnType("text")
                .HasColumnName("secret");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.Topic)
                .HasMaxLength(200)
                .HasColumnName("topic");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksWfacpStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfacp_stats");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.WfacpId, "bid");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.OrderId, "oid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.TotalRevenue)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'")
                .HasColumnName("total_revenue");
            entity.Property(e => e.WfacpId).HasColumnName("wfacp_id");
        });

        modelBuilder.Entity<IcaksWfcoConnector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfco_connectors");

            entity.HasIndex(e => e.Slug, "slug");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastSync)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("last_sync");
            entity.Property(e => e.Slug).HasColumnName("slug");
            entity.Property(e => e.Status)
                .HasComment("1 - Active 2 - Inactive")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IcaksWfcoConnectormetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfco_connectormeta");

            entity.HasIndex(e => e.ConnectorId, "connector_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConnectorId).HasColumnName("connector_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksWfcoReportView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfco_report_views");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.ObjectId, "object_id");

            entity.HasIndex(e => e.Type, "type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.NoOfSessions)
                .HasDefaultValueSql("'1'")
                .HasColumnName("no_of_sessions");
            entity.Property(e => e.ObjectId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("object_id");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasComment("1 - Abandonment 2 - Landing visited 3 - Landing converted 4 - Aero visited 5- Thank you visited 6 - NextMove 7 - Funnel session 8-Optin visited 9-Optin converted 10- Optin thank you visited 11- Optin thank you converted")
                .HasColumnName("type");
        });

        modelBuilder.Entity<IcaksWfobStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfob_stats");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Bid, "bid");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.Oid, "oid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bid).HasColumnName("bid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Converted).HasColumnName("converted");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.Iid)
                .HasMaxLength(255)
                .HasColumnName("iid");
            entity.Property(e => e.Oid).HasColumnName("oid");
            entity.Property(e => e.Total)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'")
                .HasColumnName("total");
        });

        modelBuilder.Entity<IcaksWfocuEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfocu_event");

            entity.HasIndex(e => e.ActionTypeId, "action_type_id");

            entity.HasIndex(e => e.ObjectId, "object_id");

            entity.HasIndex(e => e.ObjectType, "object_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionTypeId)
                .HasMaxLength(10)
                .HasColumnName("action_type_id");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(20)
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("object_type");
            entity.Property(e => e.SessId).HasColumnName("sess_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<IcaksWfocuEventMetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_wfocu_event_meta");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(50)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<IcaksWfocuSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icaks_wfocu_session");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.Gateway)
                .HasMaxLength(100)
                .HasColumnName("gateway");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<IcaksWoocommerceApiKey>(entity =>
        {
            entity.HasKey(e => e.KeyId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_api_keys");

            entity.HasIndex(e => e.ConsumerKey, "consumer_key");

            entity.HasIndex(e => e.ConsumerSecret, "consumer_secret");

            entity.Property(e => e.KeyId).HasColumnName("key_id");
            entity.Property(e => e.ConsumerKey)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("consumer_key");
            entity.Property(e => e.ConsumerSecret)
                .HasMaxLength(43)
                .IsFixedLength()
                .HasColumnName("consumer_secret");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.LastAccess)
                .HasColumnType("datetime")
                .HasColumnName("last_access");
            entity.Property(e => e.Nonces).HasColumnName("nonces");
            entity.Property(e => e.Permissions)
                .HasMaxLength(10)
                .HasColumnName("permissions");
            entity.Property(e => e.TruncatedKey)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("truncated_key");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksWoocommerceAttributeTaxonomy>(entity =>
        {
            entity.HasKey(e => e.AttributeId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_attribute_taxonomies");

            entity.HasIndex(e => e.AttributeName, "attribute_name");

            entity.Property(e => e.AttributeId).HasColumnName("attribute_id");
            entity.Property(e => e.AttributeLabel)
                .HasMaxLength(200)
                .HasColumnName("attribute_label");
            entity.Property(e => e.AttributeName)
                .HasMaxLength(200)
                .HasColumnName("attribute_name");
            entity.Property(e => e.AttributeOrderby)
                .HasMaxLength(20)
                .HasColumnName("attribute_orderby");
            entity.Property(e => e.AttributePublic)
                .HasDefaultValueSql("'1'")
                .HasColumnName("attribute_public");
            entity.Property(e => e.AttributeType)
                .HasMaxLength(20)
                .HasColumnName("attribute_type");
        });

        modelBuilder.Entity<IcaksWoocommerceDownloadableProductPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_downloadable_product_permissions");

            entity.HasIndex(e => new { e.ProductId, e.OrderId, e.OrderKey, e.DownloadId }, "download_order_key_product");

            entity.HasIndex(e => new { e.DownloadId, e.OrderId, e.ProductId }, "download_order_product");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => new { e.UserId, e.OrderId, e.DownloadsRemaining, e.AccessExpires }, "user_order_remaining_expires");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.AccessExpires)
                .HasColumnType("datetime")
                .HasColumnName("access_expires");
            entity.Property(e => e.AccessGranted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("access_granted");
            entity.Property(e => e.DownloadCount).HasColumnName("download_count");
            entity.Property(e => e.DownloadId)
                .HasMaxLength(36)
                .HasColumnName("download_id");
            entity.Property(e => e.DownloadsRemaining)
                .HasMaxLength(9)
                .HasColumnName("downloads_remaining");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderKey)
                .HasMaxLength(200)
                .HasColumnName("order_key");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(200)
                .HasColumnName("user_email");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksWoocommerceLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_log");

            entity.HasIndex(e => e.Level, "level");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.Context).HasColumnName("context");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .HasColumnName("source");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<IcaksWoocommerceOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_order_items");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderItemName)
                .HasColumnType("text")
                .HasColumnName("order_item_name");
            entity.Property(e => e.OrderItemType)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("order_item_type");
        });

        modelBuilder.Entity<IcaksWoocommerceOrderItemmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_order_itemmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.OrderItemId, "order_item_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
        });

        modelBuilder.Entity<IcaksWoocommercePaymentToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_payment_tokens");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.TokenId).HasColumnName("token_id");
            entity.Property(e => e.GatewayId)
                .HasMaxLength(200)
                .HasColumnName("gateway_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IcaksWoocommercePaymentTokenmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_payment_tokenmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.PaymentTokenId, "payment_token_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.PaymentTokenId).HasColumnName("payment_token_id");
        });

        modelBuilder.Entity<IcaksWoocommerceSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_sessions");

            entity.HasIndex(e => e.SessionKey, "session_key").IsUnique();

            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.SessionExpiry).HasColumnName("session_expiry");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("session_key");
            entity.Property(e => e.SessionValue).HasColumnName("session_value");
        });

        modelBuilder.Entity<IcaksWoocommerceShippingZone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_shipping_zones");

            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            entity.Property(e => e.ZoneName)
                .HasMaxLength(200)
                .HasColumnName("zone_name");
            entity.Property(e => e.ZoneOrder).HasColumnName("zone_order");
        });

        modelBuilder.Entity<IcaksWoocommerceShippingZoneLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_shipping_zone_locations");

            entity.HasIndex(e => e.LocationId, "location_id");

            entity.HasIndex(e => new { e.LocationType, e.LocationCode }, "location_type_code");

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(200)
                .HasColumnName("location_code");
            entity.Property(e => e.LocationType)
                .HasMaxLength(40)
                .HasColumnName("location_type");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
        });

        modelBuilder.Entity<IcaksWoocommerceShippingZoneMethod>(entity =>
        {
            entity.HasKey(e => e.InstanceId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_shipping_zone_methods");

            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_enabled");
            entity.Property(e => e.MethodId)
                .HasMaxLength(200)
                .HasColumnName("method_id");
            entity.Property(e => e.MethodOrder).HasColumnName("method_order");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
        });

        modelBuilder.Entity<IcaksWoocommerceTaxRate>(entity =>
        {
            entity.HasKey(e => e.TaxRateId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_tax_rates");

            entity.HasIndex(e => e.TaxRateClass, "tax_rate_class");

            entity.HasIndex(e => e.TaxRateCountry, "tax_rate_country");

            entity.HasIndex(e => e.TaxRatePriority, "tax_rate_priority");

            entity.HasIndex(e => e.TaxRateState, "tax_rate_state");

            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            entity.Property(e => e.TaxRate)
                .HasMaxLength(8)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_rate");
            entity.Property(e => e.TaxRateClass)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_rate_class");
            entity.Property(e => e.TaxRateCompound).HasColumnName("tax_rate_compound");
            entity.Property(e => e.TaxRateCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_rate_country");
            entity.Property(e => e.TaxRateName)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_rate_name");
            entity.Property(e => e.TaxRateOrder).HasColumnName("tax_rate_order");
            entity.Property(e => e.TaxRatePriority).HasColumnName("tax_rate_priority");
            entity.Property(e => e.TaxRateShipping)
                .HasDefaultValueSql("'1'")
                .HasColumnName("tax_rate_shipping");
            entity.Property(e => e.TaxRateState)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_rate_state");
        });

        modelBuilder.Entity<IcaksWoocommerceTaxRateLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("icaks_woocommerce_tax_rate_locations");

            entity.HasIndex(e => new { e.LocationType, e.LocationCode }, "location_type_code");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id");

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(200)
                .HasColumnName("location_code");
            entity.Property(e => e.LocationType)
                .HasMaxLength(40)
                .HasColumnName("location_type");
            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
