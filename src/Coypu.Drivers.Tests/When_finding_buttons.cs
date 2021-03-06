﻿using System;
using NSpec;
using NUnit.Framework;

namespace Coypu.Drivers.Tests
{
    public class When_finding_buttons : DriverSpecs
    {
        internal override void Specs()
        {
            it["finds a particular button by its text"] = () =>
            {
                driver.FindButton("first button").Id.should_be("firstButtonId");
                driver.FindButton("second button").Id.should_be("secondButtonId");
            };

            it["finds a particular button by its id"] = () =>
            {
                driver.FindButton("firstButtonId").Text.should_be("first button");
                driver.FindButton("thirdButtonId").Text.should_be("third button");
            };

            it["finds a particular button by its name"] = () =>
            {
                driver.FindButton("secondButtonName").Text.should_be("second button");
                driver.FindButton("thirdButtonName").Text.should_be("third button");
            };

            it["finds a particular input button by its value"] = () =>
            {
                driver.FindButton("first input button").Id.should_be("firstInputButtonId");
                driver.FindButton("second input button").Id.should_be("secondInputButtonId");
            };

            it["finds a particular input button by its id"] = () =>
            {
                driver.FindButton("firstInputButtonId").Value.should_be("first input button");
                driver.FindButton("thirdInputButtonId").Value.should_be("third input button");
            };
            
            it["finds a particular input button by id ends with"] = () =>
            {
                driver.FindButton("rdInputButtonId").Value.should_be("third input button");
            };

            it["finds a particular input button by its name"] = () =>
            {
                driver.FindButton("secondInputButtonId").Value.should_be("second input button");
                driver.FindButton("thirdInputButtonName").Value.should_be("third input button");
            };

            it["finds a particular submit button by its value"] = () =>
            {
                driver.FindButton("first submit button").Id.should_be("firstSubmitButtonId");
                driver.FindButton("second submit button").Id.should_be("secondSubmitButtonId");
            };

            it["finds a particular submit button by its id"] = () =>
            {
                driver.FindButton("firstSubmitButtonId").Value.should_be("first submit button");
                driver.FindButton("thirdSubmitButtonId").Value.should_be("third submit button");
            };

            it["finds a particular submit button by its name"] = () =>
            {
                driver.FindButton("secondSubmitButtonName").Value.should_be("second submit button");
                driver.FindButton("thirdSubmitButtonName").Value.should_be("third submit button");
            };

            it["finds image buttons"] = () =>
            {
                driver.FindButton("firstImageButtonId").Value.should_be("first image button");
                driver.FindButton("secondImageButtonId").Value.should_be("second image button");
            };

            it["does not find text inputs"] = () =>
            {
                Assert.Throws<MissingHtmlException>(() => driver.FindButton("firstTextInputId"));
            };

            it["does not find hidden inputs"] = () =>
            {
                Assert.Throws<MissingHtmlException>(() => driver.FindButton("firstHiddenInputId"));
            };

            it["does not find invisible inputs"] = () =>
            {
                Assert.Throws<MissingHtmlException>(() => driver.FindButton("firstInvisibleInputId"));
            };

            it["finds img elements with role='button' by alt text"] = () =>
            {
                Assert.That(driver.FindButton("I'm an image with the role of button").Id, Is.EqualTo("roleImageButtonId"));
            };

            it["finds any elements with role='button' by text"] = () =>
            {
                Assert.That(driver.FindButton("I'm a span with the role of button").Id, Is.EqualTo("roleSpanButtonId"));
            };

            it["finds an image button with both types of quote in my value"] = () =>
            {
                var button = driver.FindButton("I'm an image button with \"both\" types of quote in my value");
                Assert.That(button.Id, Is.EqualTo("buttonWithBothQuotesId"));
            };
        }
    }
}