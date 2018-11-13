<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="ArrayOfOrderDetails">
		<html>
			<head>
				<title>Order List</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="OrderDetails">
            <li>
              <xsl:value-of select="OrderNum"/>
              <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
              <xsl:value-of select="ProductName"/>
              <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
              <xsl:value-of select="Customer"/>
              <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
              <xsl:value-of select="sum"/>
              <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
              <xsl:value-of select="PhoneNum"/>
            </li>
					</xsl:for-each>
				</ul>
			</body>
		</html>
  </xsl:template>
</xsl:stylesheet>