namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class ProdTerminado
    {
        public int prdc_icod_producto {get;set;}
        public string? prdc_vcode_producto { get; set; }
        public string? prdc_vdescripcion_larga { get; set; }
        public bool prdc_isituacion { get; set; }
        public string? StrUnidadMedida { get; set; }
        public string? prdc_vcaracteristica { get; set; }
        public int prodc_icod_tipo { get; set; }
        public string? prodc_nomenclatura { get; set; }
        public string? prodc_nom_lab { get; set; }
        public string? prodc_p_a { get; set; }
        public string? prodc_env_asociado { get; set; }
        public string? prodc_vsku { get; set; }
        public string? prodc_desc_tipo_unidad_medida { get; set; }
        public string? DesCate { get; set; }
        public string? prodc_desc_tipo_tabla { get; set; }
        public decimal prod_nvalor_costo { get; set; }
        public decimal prod_nprecio_venta_vendedor { get; set; }
        public decimal prod_nprecio_venta_publico { get; set; }
         public string? FormaFar { get; set; }
        public string? prdc_des_catalogo { get; set; }
 
    }
}
