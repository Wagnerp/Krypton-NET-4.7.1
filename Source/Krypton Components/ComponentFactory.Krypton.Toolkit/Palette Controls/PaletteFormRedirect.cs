﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.471)
//  Version 5.471.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
    /// Redirect storage for PaletteForm states.
	/// </summary>
	public class PaletteFormRedirect : PaletteDoubleRedirect,
                                       IPaletteMetric
	{
		#region Instance Fields
        private readonly PaletteRedirect _redirect;
        private InheritBool _overlayHeaders;

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteFormRedirect class.
		/// </summary>
		/// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteFormRedirect(PaletteRedirect redirect,
                                   NeedPaintHandler needPaint)
            : this(redirect, redirect, needPaint)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteFormRedirect class.
		/// </summary>
        /// <param name="redirectForm">Inheritence redirection for form group.</param>
        /// <param name="redirectHeader">Inheritence redirection for header.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteFormRedirect(PaletteRedirect redirectForm,
                                   PaletteRedirect redirectHeader,
                                   NeedPaintHandler needPaint)
            : base(redirectForm, 
                   PaletteBackStyle.FormMain,
                   PaletteBorderStyle.FormMain, 
                   needPaint)
		{
            Debug.Assert(redirectForm != null);
            Debug.Assert(redirectHeader != null);
            
            // Remember the redirect reference
            _redirect = redirectForm;

            // Create the palette storage
            Header = new PaletteHeaderButtonRedirect(redirectHeader, PaletteBackStyle.HeaderForm, PaletteBorderStyle.HeaderForm, PaletteContentStyle.HeaderForm, needPaint);

			// Default other values
			_overlayHeaders = InheritBool.Inherit;
		}
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (base.IsDefault &&
		                                   Header.IsDefault &&
		                                   (OverlayHeaders == InheritBool.Inherit));

	    #endregion

        #region Header
        /// <summary>
		/// Gets access to the header appearance entries.
		/// </summary>
		[Category("Visuals")]
		[Description("Overrides for defining header appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteHeaderButtonRedirect Header { get; }

	    private bool ShouldSerializeHeader()
		{
			return !Header.IsDefault;
		}
		#endregion

        #region OverlayHeaders
        /// <summary>
		/// Gets and sets a value indicating if headers should overlay the border.
		/// </summary>
		[Category("Visuals")]
		[Description("Should headers overlay the border.")]
		[DefaultValue(typeof(InheritBool), "Inherit")]
		[RefreshPropertiesAttribute(RefreshProperties.All)]
		public InheritBool OverlayHeaders
		{
			get => _overlayHeaders;

            set
			{
				if (_overlayHeaders != value)
				{
					_overlayHeaders = value;
					PerformNeedPaint();
				}
			}
		}
		#endregion

        #region IPaletteMetric
        /// <summary>
        /// Gets an integer metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>Integer value.</returns>
        public int GetMetricInt(PaletteState state, PaletteMetricInt metric)
        {
            // Pass onto the inheritance
            return _redirect.GetMetricInt(state, metric);
        }

        /// <summary>
        /// Gets a boolean metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>InheritBool value.</returns>
        public InheritBool GetMetricBool(PaletteState state, PaletteMetricBool metric)
        {
            // Is this the metric we provide?
            if (metric == PaletteMetricBool.HeaderGroupOverlay)
            {
                // If the user has defined an actual value to use
                if (OverlayHeaders != InheritBool.Inherit)
                {
                    return OverlayHeaders;
                }
            }

            // Pass onto the inheritance
            return _redirect.GetMetricBool(state, metric);
        }

        /// <summary>
        /// Gets a padding metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>Padding value.</returns>
        public Padding GetMetricPadding(PaletteState state, PaletteMetricPadding metric)
        {
            // Always pass onto the inheritance
            return _redirect.GetMetricPadding(state, metric);
        }
        #endregion
    }
}
