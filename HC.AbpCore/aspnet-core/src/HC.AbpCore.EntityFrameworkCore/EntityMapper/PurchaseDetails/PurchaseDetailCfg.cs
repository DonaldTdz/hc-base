

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HC.AbpCore.Purchases.PurchaseDetails;

namespace HC.AbpCore.EntityMapper.PurchaseDetails
{
    public class PurchaseDetailCfg : IEntityTypeConfiguration<PurchaseDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseDetail> builder)
        {

            builder.ToTable("PurchaseDetails", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.PurchaseId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.SupplierId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Price).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.ProjectDetailId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


