 import { useState } from "react";

 export function useApi() {

  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const callApi = async (apiCall) => {
    try {
        setLoading(true)
        setError(null);
        const result = await apiCall();
        return result ; }

    catch (err) {
        setError (error.response.data.detail); 
    }
    finally {setLoading(false);
    }

    return {callApi , loading , error}
    
  }}