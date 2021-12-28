using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using _4CIWebApiClient.APISections;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient {
    public class _4CIWebAPI {
        private CosumingHelper _api;

        public _4CIWebAPI(string baseAdress) {
            _api = new CosumingHelper(baseAdress)
                                    .AddcontentType();

            Planos = new PlanosSection(_api);
            Authentication = new AuthenticationSection(_api);
            Usuaarios = new UsuariosSection(_api);
            Roles = new RolesSection(_api);
            Empresas = new EmpresasSection(_api);
            FaixasCobranca = new FaixasCobrancaSection(_api);
            MensagensAlternativasFaixaCobranca = new MensagemAlternativaFaixaCobrancaSection(_api);
            CanaisCobranca = new CanaisCobrancaSection(_api);
            ContatosEncaminhamento = new ContatosEncaminhamentoSection(_api);
            TipoCobranca = new TipoCobrancaSection(_api);
            Grupos = new GrupoEmpresasSection(_api);
            ServiceCredential = new ServiceCredentialSection(_api);
            Campanhas = new CampanhasSection(_api);
            Mensagens = new MensagensSection(_api);
            ReguasCobranca = new ReguasCobrancaSection(_api);
            Grupos = new GrupoEmpresasSection(_api);
            Dashboard = new DashboardSection(_api);
            ArquivosFaixaCobranca = new ArquivosFaixaCobrancaSection(_api);
            Enderecos = new EnderecosSection(_api);
            TriggerDefinition = new TriggerDefinitionSection(_api);
            BehaviorDefinition = new BehaviorDefinitionSection(_api);
            IBGE = new IBGESection(_api);
            CidadesAtuacao = new CidadesAtuacaoSection(_api);
            ContatosEmpresa = new ContatosEmpresaSection(_api);
            ContatoMonitoria = new ContatoMonitoriaSection(_api);
            ContatosOperacionais = new ContatoOperacionalSection(_api);
            HistoricoParalizacaoCobranca = new HistoricoParalizacaoCobrancaSection(_api);
            Logs = new LogsSection(_api);
            UploadedFile = new UploadedFileSection(_api);
        }

        //Autheticação
        public AuthenticationSection Authentication { get; internal set; }

        //Gerenciamento de Usuários
        public UsuariosSection Usuaarios { get; internal set; }
        public RolesSection Roles { get; internal set; }

        //Gerenciamento de Empresas
        public GrupoEmpresasSection Grupos { get; internal set; }
        public EmpresasSection Empresas { get; internal set; }
        public ContatosEmpresaSection ContatosEmpresa { get; internal set; } 
        public ContatoOperacionalSection ContatosOperacionais { get; internal set; }
        public CidadesAtuacaoSection CidadesAtuacao { get; internal set; }
        public PlanosSection Planos { get; internal set; }
        public HistoricoParalizacaoCobrancaSection HistoricoParalizacaoCobranca { get; internal set; }
        public TriggerDefinitionSection TriggerDefinition { get; internal set; }
        public BehaviorDefinitionSection BehaviorDefinition { get; internal set; }


        //Gerenciamneto de Réguas de Cobrança
        public CanaisCobrancaSection CanaisCobranca { get; internal set; }
        public TipoCobrancaSection TipoCobranca { get; internal set; }
        public ServiceCredentialSection ServiceCredential { get; internal set; }
        public ReguasCobrancaSection ReguasCobranca { get; internal set; }
        public FaixasCobrancaSection FaixasCobranca { get; internal set; }
        public MensagemAlternativaFaixaCobrancaSection MensagensAlternativasFaixaCobranca { get; internal set; }
        public ContatosEncaminhamentoSection ContatosEncaminhamento { get; internal set; }
        public ArquivosFaixaCobrancaSection ArquivosFaixaCobranca { get; internal set; }

        //gerenciamento de Campanhas
        public CampanhasSection Campanhas { get; internal set; } 
        public MensagensSection Mensagens { get; internal set; } 

        //Dashboard
        public DashboardSection Dashboard { get; internal set; }

        
        //gerenciamento de Clientes
        public EnderecosSection Enderecos { get; internal set; }
        public IBGESection IBGE { get; internal set; }

        //Gerenciamento de Monitoria
        public ContatoMonitoriaSection ContatoMonitoria { get; internal set; }

        //Gerencimento de Logs
        public LogsSection Logs { get; internal set; }

        //Gerencimento de Aruvos
        public UploadedFileSection UploadedFile { get; internal set; }
    }
}
