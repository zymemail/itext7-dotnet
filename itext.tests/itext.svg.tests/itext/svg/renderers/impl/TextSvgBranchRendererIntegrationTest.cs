/*
This file is part of the iText (R) project.
Copyright (c) 1998-2019 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.StyledXmlParser.Exceptions;
using iText.Svg.Renderers;
using iText.Test;

namespace iText.Svg.Renderers.Impl {
    public class TextSvgBranchRendererIntegrationTest : SvgIntegrationTest {
        private static readonly String SOURCE_FOLDER = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/svg/renderers/impl/TextSvgBranchRendererIntegrationTest/";

        private static readonly String DESTINATION_FOLDER = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/svg/renderers/impl/TextSvgBranchRendererIntegrationTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            ITextTest.CreateDestinationFolder(DESTINATION_FOLDER);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TooLongTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "too_long");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TwoLinesTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "two_lines");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TwoLinesNewlineTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "two_lines_newline");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldScaleUpXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_scaleUpX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldScaleUpYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_scaleUpY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldScaleDownXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_scaleDownX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldScaleDownYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_scaleDownY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldTranslateTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_translate");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldRotateTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_rotate");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldSkewXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_skewX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldSkewYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_skewY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldCombinedTransformationsTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_combinedTransformations");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void HelloWorldFontSizeMissingTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "hello_world_fontSizeMissing");
        }

        //Absolute position
        //X
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionpositiveXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-positiveX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionnegativeXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-negativeX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionzeroXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-zeroX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionInvalidXTest() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-invalidX");
            }
            , NUnit.Framework.Throws.InstanceOf<StyledXMLParserException>())
;
        }

        //Y
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionPositiveYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-positiveY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionNegativeYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-negativeY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionZeroYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-zeroY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextAbsolutePositionInvalidYTest() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-absolutePosition-invalidY");
            }
            , NUnit.Framework.Throws.InstanceOf<StyledXMLParserException>())
;
        }

        //Relative move
        //X
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMovePositiveXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-positiveX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveNegativeXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-negativeX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveZeroXTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-zeroX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveInvalidXTest() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-invalidX");
            }
            , NUnit.Framework.Throws.InstanceOf<StyledXMLParserException>())
;
        }

        //Y
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMovePositiveYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-positiveY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveNegativeYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-negativeY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveZeroYTest() {
            ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-zeroY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void TextRelativeMoveInvalidYTest() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompareVisually(SOURCE_FOLDER, DESTINATION_FOLDER, "text-relativeMove-invalidY");
            }
            , NUnit.Framework.Throws.InstanceOf<StyledXMLParserException>())
;
        }
    }
}
