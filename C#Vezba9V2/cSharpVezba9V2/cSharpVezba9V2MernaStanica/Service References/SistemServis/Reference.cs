﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cSharpVezba9V2MernaStanica.SistemServis {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SistemServis.ISistemServis")]
    public interface ISistemServis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISistemServis/Temperatura", ReplyAction="http://tempuri.org/ISistemServis/TemperaturaResponse")]
        bool Temperatura(string stanica, double vrednost, System.DateTime vreme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISistemServis/Temperatura", ReplyAction="http://tempuri.org/ISistemServis/TemperaturaResponse")]
        System.Threading.Tasks.Task<bool> TemperaturaAsync(string stanica, double vrednost, System.DateTime vreme);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISistemServisChannel : cSharpVezba9V2MernaStanica.SistemServis.ISistemServis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SistemServisClient : System.ServiceModel.ClientBase<cSharpVezba9V2MernaStanica.SistemServis.ISistemServis>, cSharpVezba9V2MernaStanica.SistemServis.ISistemServis {
        
        public SistemServisClient() {
        }
        
        public SistemServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SistemServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SistemServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SistemServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Temperatura(string stanica, double vrednost, System.DateTime vreme) {
            return base.Channel.Temperatura(stanica, vrednost, vreme);
        }
        
        public System.Threading.Tasks.Task<bool> TemperaturaAsync(string stanica, double vrednost, System.DateTime vreme) {
            return base.Channel.TemperaturaAsync(stanica, vrednost, vreme);
        }
    }
}
