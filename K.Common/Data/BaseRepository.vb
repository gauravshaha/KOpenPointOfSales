
Imports K.Common.R2.Identity.Entities
Imports K.Common.R2.Identity
Imports NHibernate.Tool.hbm2ddl
Imports NHibernate.Mapping.ByCode
Imports NHibernate.Cfg.MappingSchema
Imports NHibernate.Cfg
Imports NHibernate
Imports System.Reflection

Namespace Data

    Public MustInherit Class BaseRepository

        Private Shared _configuration As Configuration
        Protected Shared SessionFactory As ISessionFactory
        Private _session As ISession
        Private _statelessSession As IStatelessSession

        Public Shared Function ConfigureNHibernate(assembly As String) As Configuration
            _configuration = New Configuration()
            _configuration.AddAssembly(assembly)
            Dim _mapping = GetMapping()
            _configuration.AddDeserializedMapping(_mapping, assembly)
            SchemaMetadataUpdater.QuoteTableAndColumns(_configuration)
            Return _configuration
        End Function

        Protected Shared Function GetMapping() As HbmMapping
            Dim _mapper As New ModelMapper()
            _mapper.AddMappings(Assembly.GetAssembly(GetType(ConfigBase)).GetExportedTypes())
            Return _mapper.CompileMappingForAllExplicitlyAddedEntities()
        End Function

    End Class
End Namespace