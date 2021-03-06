﻿
using Reinforced.Tecture.Channels;



namespace Reinforced.Tecture.Services {	
	
 
	

	/// <summary>
    /// Storage services with 2 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 3 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 4 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3, Tool4>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   where Tool4 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3, Tool4> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3, Tool4>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3, Tool4> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3, Tool4>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 5 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3, Tool4, Tool5>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   where Tool4 : Tooling
			   where Tool5 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3, Tool4, Tool5> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3, Tool4, Tool5>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3, Tool4, Tool5> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3, Tool4, Tool5>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 6 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3, Tool4, Tool5, Tool6>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   where Tool4 : Tooling
			   where Tool5 : Tooling
			   where Tool6 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 7 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   where Tool4 : Tooling
			   where Tool5 : Tooling
			   where Tool6 : Tooling
			   where Tool7 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7>(ChannelMultiplexer, Pipeline);
        }	
    }

 
	

	/// <summary>
    /// Storage services with 8 toolings
    /// </summary>    
	public class TectureService<Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7, Tool8>
			   : TectureServiceBase
			   where Tool1: Tooling
			   where Tool2 : Tooling
			   where Tool3 : Tooling
			   where Tool4 : Tooling
			   where Tool5 : Tooling
			   where Tool6 : Tooling
			   where Tool7 : Tooling
			   where Tool8 : Tooling
			   
    {

        /// <summary>
        /// Gets reading end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain read end of</typeparam>
        /// <returns>Channel's read end</returns>
        protected Read<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7, Tool8> From<T>() where T : CanQuery
        {
            return new SRead<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7, Tool8>(ChannelMultiplexer);
        }		

        /// <summary>
        /// Gets writing end of channel <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Channel to obtain write end of</typeparam>
        /// <returns>Channel's write end</returns>
		protected Write<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7, Tool8> To<T>() where T : CanCommand
        {
            return new SWrite<T, Tool1, Tool2, Tool3, Tool4, Tool5, Tool6, Tool7, Tool8>(ChannelMultiplexer, Pipeline);
        }	
    }

}

