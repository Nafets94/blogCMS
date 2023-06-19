import { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Container, CssBaseline, List, ListItem, ListItemIcon, ListItemText, Typography } from '@mui/material';
import InboxIcon from '@mui/icons-material/Inbox';

function App() {
  const [posts, setPosts] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/posts')
      .then(response => {
        console.log(response.data);
        setPosts(response.data);
      })
  }, [])

  return (
    <>
      <CssBaseline />
      <Container maxWidth="lg" style={{backgroundColor: 'lightGray'}}>
        <Typography variant="h1">My great Blog</Typography>
        <List>
          {posts.map((post: any) => (
            <ListItem key={post.id}>
              <ListItemIcon>
                <InboxIcon />
              </ListItemIcon>
              <ListItemText>
                {post.title}
              </ListItemText>
            </ListItem>
          ))}
        </List>
      </Container>
    </>
  );
}

export default App;
