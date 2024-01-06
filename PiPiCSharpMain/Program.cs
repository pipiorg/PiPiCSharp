using PiPiCSharp;

var pdfBytes = File.ReadAllBytes("D:\\Empty.pdf");

PiPiCSharpOperator op = new PiPiCSharpOperator(pdfBytes);
