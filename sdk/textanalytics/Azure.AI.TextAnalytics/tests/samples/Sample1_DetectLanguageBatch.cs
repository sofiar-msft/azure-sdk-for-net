﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void DetectLanguageBatch()
        {
            // Create a text analytics client.
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;
            TextAnalyticsClient client = new(new Uri(endpoint), new AzureKeyCredential(apiKey), CreateSampleOptions());

            #region Snippet:TextAnalyticsSample1DetectLanguageBatch
            string documentA =
                "Este documento está escrito en un lenguaje diferente al inglés. Su objectivo es demostrar cómo"
                + " invocar el método de detección de lenguaje del servicio de Text Analytics en Microsoft Azure."
                + " También muestra cómo acceder a la información retornada por el servicio. Esta funcionalidad es"
                + " útil para las aplicaciones que recopilan texto arbitrario donde el lenguaje no se conoce de"
                + " antemano. Puede usarse para detectar una amplia gama de lenguajes, variantes, dialectos y"
                + " algunos idiomas regionales o culturales.";

            string documentB =
                "This document is written in English. Its objective is to demonstrate how to call the language"
                + " detection method of the Text Analytics service in Microsoft Azure. It also shows how to access the"
                + " information returned by the service. This functionality is useful for applications that collect"
                + " arbitrary text where the language is not known beforehand. It can be used to detect a wide range"
                + " of languages, variants, dialects, and some regional or cultural languages.";

            string documentC =
                "Ce document est rédigé dans une langue autre que l'anglais. Son objectif est de montrer comment"
                + " appeler la méthode de détection de langue du service Text Analytics dans Microsoft Azure. Il"
                + " montre également comment accéder aux informations renvoyées par le service. Cette fonctionnalité"
                + " est utile pour les applications qui collectent du texte arbitraire dont la langue n'est pas connue"
                + " à l'avance. Il peut être utilisé pour détecter un large éventail de langues, de variantes, de"
                + " dialectes et certaines langues régionales ou culturelles.";

            string documentD = "Tumhara naam kya hai?";

            string documentE = ":) :( :D";

            string documentF = string.Empty;

            List<DetectLanguageInput> documents = new()
            {
                new DetectLanguageInput("1", documentA)
                {
                     CountryHint = "es",
                },
                new DetectLanguageInput("2", documentB)
                {
                     CountryHint = "us",
                },
                new DetectLanguageInput("3", documentC)
                {
                     CountryHint = "fr",
                },
                new DetectLanguageInput("4", documentD)
                {
                     CountryHint = "in",
                },
                new DetectLanguageInput("5", documentE)
                {
                     CountryHint = DetectLanguageInput.None,
                },
                new DetectLanguageInput("6", documentF)
                {
                     CountryHint = "us",
                }
            };

            TextAnalyticsRequestOptions options = new() { IncludeStatistics = true };

            Response<DetectLanguageResultCollection> response = client.DetectLanguageBatch(documents, options);
            DetectLanguageResultCollection documentsLanguage = response.Value;

            int i = 0;
            Console.WriteLine($"Results of \"Detect Language\" Model, version: \"{documentsLanguage.ModelVersion}\"");
            Console.WriteLine();

            foreach (DetectLanguageResult documentLanguage in documentsLanguage)
            {
                DetectLanguageInput document = documents[i++];

                Console.WriteLine($"On document (Id={document.Id}, CountryHint=\"{document.CountryHint}\"):");

                if (documentLanguage.HasError)
                {
                    Console.WriteLine("  Error!");
                    Console.WriteLine($"  Document error code: {documentLanguage.Error.ErrorCode}.");
                    Console.WriteLine($"  Message: {documentLanguage.Error.Message}");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine($"  Detected language: {documentLanguage.PrimaryLanguage.Name}");
                Console.WriteLine($"  Confidence score: {documentLanguage.PrimaryLanguage.ConfidenceScore}");
                if (documentLanguage.PrimaryLanguage.Script is not null)
                    Console.WriteLine($"  Script: {documentLanguage.PrimaryLanguage.Script}");

                Console.WriteLine($"  Document statistics:");
                Console.WriteLine($"    Character count: {documentLanguage.Statistics.CharacterCount}");
                Console.WriteLine($"    Transaction count: {documentLanguage.Statistics.TransactionCount}");
                Console.WriteLine();
            }

            Console.WriteLine($"Batch operation statistics:");
            Console.WriteLine($"  Document count: {documentsLanguage.Statistics.DocumentCount}");
            Console.WriteLine($"  Valid document count: {documentsLanguage.Statistics.ValidDocumentCount}");
            Console.WriteLine($"  Invalid document count: {documentsLanguage.Statistics.InvalidDocumentCount}");
            Console.WriteLine($"  Transaction count: {documentsLanguage.Statistics.TransactionCount}");
            #endregion
        }
    }
}
