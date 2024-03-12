using AutoMapper;
using EKEKOSDATABASEMODEL;
using REQUESTRESPONSEMODEL;

namespace UTILAUTOMAPPER
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioLoginResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<UsuarioResponse>, GenericFilterResponse<Usuario>>().ReverseMap();

            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaResponse>, GenericFilterResponse<Persona>>().ReverseMap();

            CreateMap<Rol, RolRequest>().ReverseMap();
            CreateMap<Rol, RolResponse>().ReverseMap();
            CreateMap<RolRequest, RolResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<RolResponse>, GenericFilterResponse<Rol>>().ReverseMap();

            CreateMap<Cargo, CargoRequest>().ReverseMap();
            CreateMap<Cargo, CargoResponse>().ReverseMap();
            CreateMap<CargoRequest, CargoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<CargoResponse>, GenericFilterResponse<Cargo>>().ReverseMap();

            CreateMap<Colaborador, ColaboradorRequest>().ReverseMap();
            CreateMap<Colaborador, ColaboradorResponse>().ReverseMap();
            CreateMap<ColaboradorRequest, ColaboradorResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ColaboradorResponse>, GenericFilterResponse<Colaborador>>().ReverseMap();

            CreateMap<DetallePedido, DetallePedidoRequest>().ReverseMap();
            CreateMap<DetallePedido, DetallePedidoResponse>().ReverseMap();
            CreateMap<DetallePedidoRequest, DetallePedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DetallePedidoResponse>, GenericFilterResponse<DetallePedido>>().ReverseMap();

            CreateMap<Error, ErrorRequest>().ReverseMap();
            CreateMap<Error, ErrorResponse>().ReverseMap();
            CreateMap<ErrorRequest, ErrorResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ErrorResponse>, GenericFilterResponse<Error>>().ReverseMap();

            CreateMap<Menu, MenuRequest>().ReverseMap();
            CreateMap<Menu, MenuResponse>().ReverseMap();
            CreateMap<MenuRequest, MenuResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<MenuResponse>, GenericFilterResponse<Menu>>().ReverseMap();

            CreateMap<MenuRol, MenuRolRequest>().ReverseMap();
            CreateMap<MenuRol, MenuRolResponse>().ReverseMap();
            CreateMap<MenuRolRequest, MenuRolResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<MenuRolResponse>, GenericFilterResponse<MenuRol>>().ReverseMap();

            CreateMap<Mesa, MesaRequest>().ReverseMap();
            CreateMap<Mesa, MesaResponse>().ReverseMap();
            CreateMap<MesaRequest, MesaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<MesaResponse>, GenericFilterResponse<Mesa>>().ReverseMap();

            CreateMap<MetodoPago, MetodoPagoRequest>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoResponse>().ReverseMap();
            CreateMap<MetodoPagoRequest, MetodoPagoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<MetodoPagoResponse>, GenericFilterResponse<MetodoPago>>().ReverseMap();

            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();
            CreateMap<PedidoRequest, PedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PedidoResponse>, GenericFilterResponse<Pedido>>().ReverseMap();

            CreateMap<PersonaGenero, PersonaGeneroRequest>().ReverseMap();
            CreateMap<PersonaGenero, PersonaGeneroResponse>().ReverseMap();
            CreateMap<PersonaGeneroRequest, PersonaGeneroResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaGeneroResponse>, GenericFilterResponse<PersonaGenero>>().ReverseMap();

            CreateMap<PersonaTipoDocumento, PersonaTipoDocumentoRequest>().ReverseMap();
            CreateMap<PersonaTipoDocumento, PersonaTipoDocumentoResponse>().ReverseMap();
            CreateMap<PersonaTipoDocumentoRequest, PersonaTipoDocumentoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaTipoDocumentoResponse>, GenericFilterResponse<PersonaTipoDocumento>>().ReverseMap();

            CreateMap<PersonTipo, PersonaTipoRequest>().ReverseMap();
            CreateMap<PersonTipo, PersonaTipoResponse>().ReverseMap();
            CreateMap<PersonaTipoRequest, PersonaTipoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaTipoResponse>, GenericFilterResponse<PersonTipo>>().ReverseMap();

            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();
            CreateMap<ProductoRequest, ProductoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ProductoResponse>, GenericFilterResponse<Producto>>().ReverseMap();

            CreateMap<ProductoCategorium, ProductoCategoriumRequest>().ReverseMap();
            CreateMap<ProductoCategorium, ProductoCategoriumResponse>().ReverseMap();
            CreateMap<ProductoCategoriumRequest, ProductoCategoriumResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ProductoCategoriumResponse>, GenericFilterResponse<ProductoCategorium>>().ReverseMap();

            CreateMap<UbicacionGeo, UbicacionGeoRequest>().ReverseMap();
            CreateMap<UbicacionGeo, UbicacionGeoResponse>().ReverseMap();
            CreateMap<UbicacionGeoRequest, UbicacionGeoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<UbicacionGeoResponse>, GenericFilterResponse<UbicacionGeo>>().ReverseMap();

            CreateMap<UserSesion, UserSesionRequest>().ReverseMap();
            CreateMap<UserSesion, UserSesionResponse>().ReverseMap();
            CreateMap<UserSesionRequest, UserSesionResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<UserSesionResponse>, GenericFilterResponse<UserSesion>>().ReverseMap();

        }

    }
}
