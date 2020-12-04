using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebconIntegrationSystem.Models.BPSMainAtt;

namespace WebconIntegrationSystem.Data.BPSMainAtt
{
    public class WfattachmentFilesConfiguration : IEntityTypeConfiguration<WfattachmentFiles>
    {
        public void Configure(EntityTypeBuilder<WfattachmentFiles> builder)
        {
            builder.Property(e => e.AtfFileType).HasDefaultValueSql("('pdf')");

            builder.Property(e => e.AtfOrginalName).IsUnicode(false);

            builder.Property(e => e.AtfOrginalValueHash).IsFixedLength();

            builder.Property(e => e.AtfRowVersion).IsRowVersion();
        }
    }
}
