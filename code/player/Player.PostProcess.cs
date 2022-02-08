﻿using Sandbox;

namespace Fortwars
{
	partial class FortwarsPlayer
	{
		private static StandardPostProcess postProcess;

		private static void SetupPostProcessing()
		{
			Host.AssertClient();

			PostProcess.Add<StandardPostProcess>( new() );
			postProcess = PostProcess.Get<StandardPostProcess>();
		}

		[Event.Frame]
		private static void UpdatePostProcessing()
		{
			Host.AssertClient();

			if ( postProcess == null )
			{
				SetupPostProcessing();
			}

			postProcess.FilmGrain.Enabled = true;
			postProcess.FilmGrain.Intensity = 0.15f;
			postProcess.FilmGrain.Response = 1f;

			postProcess.LensDistortion.Enabled = true;
			postProcess.LensDistortion.K1 = 0f;
			postProcess.LensDistortion.K2 = -0.005f;

			//postProcess.ChromaticAberration.Enabled = true;
			//postProcess.ChromaticAberration.Offset = Vector3.Up * 0.0005f;

			//postProcess.Vignette.Enabled = true;
			//postProcess.Vignette.Intensity = 0.5f;
			//postProcess.Vignette.Roundness = 1.0f;
			//postProcess.Vignette.Smoothness = 0.5f;
		}
	}
}