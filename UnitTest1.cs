using AulaTestes;

namespace AulaTestes.Tests
{
    public class ValidadorSenhaTests
    {
        [Fact]
        public void SenhaComLetraENumeroDeveSerValida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("Senha123");

            Assert.True(resultado);
        }

        [Fact]
        public void SenhaSomenteComNumerosDeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("12345678");

            Assert.False(resultado);
        }

        [Fact]
        public void SenhaVaziaDeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("");

            Assert.False(resultado);
        }

        [Fact]
        public void SenhaSomenteComLetrasDeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("abcdEFGH");

            Assert.False(resultado);
        }

        [Fact]
        public void DeveSomarCorretamenteOTotal()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Arroz",
                Preco = 20
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Feijão",
                Preco = 10
            });

            double total = carrinho.Total();

            Assert.Equal(30, total);
        }

        [Fact]
        public void LimparDeveDeixarCarrinhoVazio()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Arroz",
                Preco = 20
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Feijão",
                Preco = 10
            });

            carrinho.Limpar();

            Assert.Equal(0, carrinho.Quantidade());
        }

        [Fact]
        public void QuantidadeDeveRetornarNumeroCorretoDeItens()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Arroz",
                Preco = 20
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Feijão",
                Preco = 10
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Macarrão",
                Preco = 8
            });

            Assert.Equal(3, carrinho.Quantidade());
        }

        [Fact]
        public void CelsiusZeroDeveRetornarFahrenheit32()
        {
            var conversor = new ConversorTemperatura();

            double resultado = conversor.CelsiusParaFahrenheit(0);

            Assert.Equal(32, resultado, 2);
        }

        [Fact]
        public void Celsius100DeveRetornarFahrenheit212()
        {
            var conversor = new ConversorTemperatura();

            double resultado = conversor.CelsiusParaFahrenheit(100);

            Assert.Equal(212, resultado, 2);
        }

        [Fact]
        public void Fahrenheit32DeveRetornarCelsius0()
        {
            var conversor = new ConversorTemperatura();

            double resultado = conversor.FahrenheitParaCelsius(32);

            Assert.Equal(0, resultado, 2);
        }
        [Fact]
        public void Fahrenheit212DeveRetornarCelsius100()
        {
            var conversor = new ConversorTemperatura();

            double resultado = conversor.FahrenheitParaCelsius(212);

            Assert.Equal(100, resultado, 2);
        }

        [Fact]
        public void CalcularIMCDeveRetornarValorCorreto()
        {
            var calculadora = new CalculadoraIMC();

            double resultado = calculadora.Calcular(70, 1.75);

            Assert.Equal(22.86, resultado, 2);
        }

        [Fact]
        public void IMC17DeveSerAbaixoDoPeso()
        {
            var calculadora = new CalculadoraIMC();

            string resultado = calculadora.Classificar(17);

            Assert.Equal("Abaixo do peso", resultado);
        }

        [Fact]
        public void IMC26DeveSerSobrepeso()
        {
            var calculadora = new CalculadoraIMC();

            string resultado = calculadora.Classificar(26);

            Assert.Equal("Sobrepeso", resultado);
        }
        [Fact]
        public void AlturaZeroDeveLancarExcecao()
        {
            var calculadora = new CalculadoraIMC();

            Assert.Throws<ArgumentException>(() =>
                calculadora.Calcular(70, 0));
        }
    }
}